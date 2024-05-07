---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-03 18:30
definition: Automatic scaling is a new scale-out option that automatically handles scaling decisions for your web apps and App Service Plans.
ms-learn-url: https://learn.microsoft.com/en-us/azure/app-service/manage-automatic-scaling?tabs=azure-portal
---

|   MetaData |                                       |
| ---------- | ------------------------------------------ |
| Definition | `VIEW[{definition}][text(renderMarkdown)]` |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]` |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |



Different from previous: [[Azure autoscale]].

Autoscaling is a cloud system or process that adjusts available resources based on the current demand. Autoscaling performs scaling _in and out_, as opposed to scaling _up and down_.

Autoscaling in [[Azure App Service]] monitors the resource metrics of a [[Azure Web App|web app]] as it runs. It detects situations where other resources are required to handle an increasing workload, and ensures those resources are available before the system becomes overloaded.

Autoscaling responds to changes in the environment by adding or removing web servers and balancing the load between them. Autoscaling doesn't have any effect on the CPU power, memory, or storage capacity of the web servers powering the app, it only changes the number of web servers.


> [!warning] 
> Trying to handle a surge in requests caused by a [[Distributed Denial of Service|DoS]] attack would be fruitless and expensive.

Autoscaling isn't the best approach to handling long-term growth. Better to manual scale over time based on the increased needs ( minimal instances)

Autoscaling improves [[availability]] and [[fault tolerance]].
### Scaling Options for [[Azure App Service Plan]]

Free: No scaling
Dev: No scaling
Basic: Manual scaling for this tier and higher
Standard(legacy): [[Azure autoscale|autoscale]]
Premium: Automatic Scaling

### Scaling Configuration

You enable automatic scaling for an App Service Plan and configure a range of instances for each of the web apps.

#### Azure provides two options for autoscaling:

- <u>Scale based on a metric</u>, such as the length of the disk queue, or the number of HTTP requests awaiting processing.
- <u>Scale to a specific instance count according to a schedule.</u> For example, you can arrange to scale out at a particular time of day, or on a specific date or day of the week. You also specify an end date, and the system scales back in at this time.

##### Metric options
- **CPU Percentage**. This metric is an indication of the CPU utilization across all instances. A high value shows that instances are becoming [[CPU-bound]], which could cause delays in processing client requests.
- **Memory Percentage**. This metric captures the memory occupancy of the application across all instances. A high value indicates that free memory could be running low, and could cause one or more instances to fail.
- **Disk Queue Length**. This metric is a measure of the number of outstanding I/O requests across all instances. A high value means that disk contention could be occurring.
- **Http Queue Length**. This metric shows how many client requests are waiting for processing by the web app. If this number is large, client requests might fail with [[HTTP 408]] (Timeout) errors.
- **Data In**. This metric is the number of bytes received across all instances.
- **Data Out**. This metric is the number of bytes sent by all instances.

> [!info]
> You can also scale based on metrics for other Azure services like too many message from [[Azure Service Bus]]



#### Max Burst
**Maximum burst** is the highest number of instances that your [[Azure App Service Plan]] can increase to based on incoming HTTP requests.
Premium tier -> can scale up to 30 instances

##### Setting Max Burst with [[Azure CLI|az]]
```shell
az appservice plan update --name <APP_SERVICE_PLAN> --resource-group <RESOURCE_GROUP> --elastic-scale true --max-elastic-worker-count <YOUR_MAX_BURST>
```

#### Minimal instances
**Always ready instances** is an app-level setting to specify the minimum number of instances.

##### Setting minimal instances with [[Azure CLI|az]]
```shell
az webapp update --resource-group <RESOURCE_GROUP> --name <APP_NAME> --minimum-elastic-instance-count <ALWAYS_READY_COUNT>
```

## ## How an autoscale rule analyzes metrics

Autoscaling works by analyzing trends in metric values over time across all instances. Analysis is a multi-step process.

### time grain

In the first step, an autoscale rule aggregates the values retrieved for a metric for all instances across a period of time known as the _[[time grain]]_. Each metric has its own intrinsic time grain, 

> [!info]
> In most cases the time grain or  period is 1 minute. 

The aggregated value is known as the _time aggregation_. 

> [!info]
> The options available are _Average_, _Minimum_, _Maximum_, _Sum_, _Last_, and _Count_.


### time aggregation or duration

An interval of one minute is a short interval in which to determine whether any change in metric is long-lasting enough to make autoscaling worthwhile. So, an autoscale rule performs a second step that performs a further aggregation of the value calculated by the _time aggregation_ over a longer, user-specified period, known as the _Duration_. 

> [!info]
> The minimum _Duration_ is 5 minutes. 

If the _Duration_ is set to 10 minutes for example, the autoscale rule aggregates the 10 values calculated for the _time grain_.



The aggregation calculation for the _Duration_ can be different from the _time grain_. For example, if the _time aggregation_ is _Average_ and the statistic gathered is _CPU Percentage_ across a one-minute _time grain_, each minute the average CPU percentage utilization across all instances for that minute is calculated. If the [[time grain statistic]] is set to _Maximum_, and the _Duration_ of the rule is set to 10 minutes, the maximum of the 10 average values for the CPU percentage utilization is to determine whether the rule threshold has been crossed.

## Autoscale actions

> [!info]
> An autoscale action can be _scale-out_ or _scale-in_.

> [!NOTE]
> An autoscale action has a _cool down_ period, specified in minutes.

> [!info]
> The minimum cool down period is five minutes.

## Pairing [[autoscale rules]]

> [!tip]
> Consider defining autoscale rules in pairs in the same autoscale condition.

What goes up, must come down... (or in this case in/out)

## Enable autoscaling

Check [[#Scaling Options for Azure App Service Plan|scaling options]] [[Azure App Service Plan]] for which tiers support autoscaling.

- Choose Custom autoscale
- Add scale conditions 
	- Based on Metric (min/max)
	- Specify Instance count

> [!attention]
> The Default scale condition is executed when none of the other scale conditions are active.

> [!info]
> Conditions other then default can have a shedule

## Create scale rules
- [ ] Practice settings for creating an autoscaling rule

## Monitor autoscaling activity

[[Azure Portal]] allows you to monitor.

The Azure portal enables you to track when autoscaling has occurred through the **Run history** chart.

## Explore autoscale best practices

### Autoscale concepts

- An autoscale setting scales instances horizontally, which is _out_ by increasing the instances and _in_ by decreasing the number of instances. 
	- An autoscale setting has a maximum, minimum, and default value of instances.
- An autoscale job always reads the associated metric to scale by, checking if it has crossed the configured threshold for scale-out or scale-in.
- All thresholds are calculated at an instance level. 
- All autoscale successes and failures are logged to the [[Activity Log]]. You can then configure an [[activity log alert]] so that you can be notified via email, SMS, or webhooks whenever there's activity.
### Ensure the maximum and minimum values are different and have an adequate margin between them

### Choose the appropriate statistic for your diagnostics metric

For diagnostics metrics, you can choose among _Average_, _Minimum_, _Maximum_ and _Total_ as a metric to scale by. The most common statistic is Average.

### Choose the thresholds carefully for all metric types

We recommend carefully choosing different thresholds for scale-out and scale-in based on practical situations.

We _don't recommend_ autoscale settings like the following examples with the same or similar threshold values for out and in conditions:
- Increase instances by one count when Thread Count >= 600
- Decrease instances by one count when Thread Count <= 600

If there were 2 instances and thread count is 625 in each instance.
We add a third.
Later we see 575 in each of the 3 instances.

> [!danger] 
> If we would scale in, the 2 instances would immediately trigger an scale out again!
> 

> [!attention]
> To avoid this situation (termed "[[flapping]]"), autoscale doesn't scale in at all.


### Considerations for scaling when multiple rules are configured in a profile

There are cases where you may have to set multiple rules in a profile. The following set of autoscale rules are used by services when multiple rules are set.

- On _scale-out_, autoscale runs if any rule is met. 
- On _scale-in_, autoscale require all rules to be met.
### Always select a safe default instance count

The default instance count is important because autoscale scales your service to that count when metrics aren't available. Therefore, 

> [!attention]
> select a default instance count that's safe for your workloads.

### Configure autoscale notifications
- [ ] Try out Activity Log alerts

Autoscale posts to the Activity Log if any of the following conditions occur:
- Autoscale issues a scale operation
- Autoscale service successfully completes a scale action
- Autoscale service fails to take a scale action.
- Metrics aren't available for autoscale service to make a scale decision.
- Metrics are available (recovery) again to make a scale decision.

You can also use an Activity Log alert to monitor the health of the autoscale engine. In addition to using activity log alerts, you can also configure email or webhook notifications to get notified for successful scale actions via the notifications tab on the autoscale setting.
## Does automatic scaling support [[Azure Functions]] apps?

> [!caution]  
> Automatic Scaling is disabled when App Service web apps and Azure Function apps are in the same App Service Plan.

^580ed5

No, you can only have Azure App Service web apps in the App Service Plan where you wish to enable automatic scaling. For Functions, it's recommended to use the [[Azure Functions Premium plan]] instead.