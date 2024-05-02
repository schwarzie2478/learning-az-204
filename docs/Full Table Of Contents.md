 ```dataviewjs
    let p = dv.pages('"Concepts"') // Retrieve pages with title "path/to/your/notes"
          .where(p => p.file.name != dv.current().file.name) // Filter out the current page
          .sort(p => p.file.ctime) //sort pages by creation time
          .forEach(p => { //for each page
            dv.header(2, p.file.name); // Display page name as header
            const cache = this.app.metadataCache.getCache(p.file.path);//get metadata cache for the page
            
            if (cache) { // If cache exists
              const headings = cache.headings; // Get the headings from the cache
              
              if (headings) { //if headings exist
                const filteredHeadings = headings.slice(1) //exclude the first heading
                  .filter(h => h.level <= 4) // Filter headings based on level (up to level 4)
                  .map(h => {
                    let indent = " ".repeat(h.level - 1);// Determine indentation based on heading level
                   // let linkyHeading = "[[#" + h.heading + "]]";
    //Correct linking code
    let linkyHeading = "[[" + p.file.name + "#" + h.heading + "|" + h.heading + "]]";
    
         
               return indent + "- " + linkyHeading;
                  })
                  .join("\n");// Join the formatted headings with newlines
                
                dv.el("div", filteredHeadings);// Display the formatted headings as a div
              }
            }
          });
```
    