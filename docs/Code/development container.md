---
status: planted
dg-publish: true
tags:
  - code
creation_date: 2024-05-10 09:52
definition: undefined
ms-learn-url: undefined
url: https://containers.dev/
aliases:
  - devcontainer
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

- [ ] See https://code.visualstudio.com/docs/devcontainers/containers for additional info.

## Learn more

- [Development Containers Specification](https://containers.dev/implementors/spec/)
- [Dev Containers tutorial](https://code.visualstudio.com/docs/remote/containers-tutorial)
- [Learn to create a development container](https://code.visualstudio.com/docs/remote/create-dev-container)
- [Main Dev Containers documentation](https://code.visualstudio.com/docs/remote/containers)
- [How educators can use dev containers](https://code.visualstudio.com/blogs/2020/07/27/containers-edu)
- [How students can use dev containers](https://youtu.be/Uvf2FVS1F8k)
- [File an issue or request a feature on GitHub](https://github.com/microsoft/vscode-remote-release/issues)

## setup example
1. Navigating back to your **Code** tab of your repository, click the **Add file** drop-down button, and then click `Create new file`.
    
2. Type or paste the following in the empty text field prompt to name your file.
    
    ```
    .devcontainer/devcontainer.json
    ```
    
3. In the body of the new **.devcontainer/devcontainer.json** file, add the following content:
    
    ```
    {
        // Name this configuration
        "name": "Codespace for Skills!",
        "customizations": {
            "vscode": {
                "extensions": [
                    "GitHub.copilot"
                ]
            }
        }
    }
    ```