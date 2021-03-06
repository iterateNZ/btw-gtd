# Expedition Itinerary #

- **Expedition 2**
    - Getting started with Module 2 of BTW and GTD Domain
        - Podcast
            - Modular structure overview
            - Recap Module 1
            - Remind about limited applicability - we are exploring
              options
            - Goals of module 2
                - Build on Module 1
                - Explore additional fields:
                    - Basic team collaboration practices
                    - Multiple Clients
                    - Development process
                    - Versioning production systems
                    - Concurrency and occasional connectivity
            - Explain task at hand:
                - Build an app to capture GTD methodology
            - Sample code principles: github project to evolve
        - References:
            - David Allen's book
            - Getting started with GTD
                  http://www.43folders.com/2004/09/08/getting-started-with-getting-things-done
                  <http://www.43folders.com/2004/09/08/getting-started-with-getting-things-done>
            - GTD with Omnifocus
        - Home work:
            - Familiarize with domain
            - List most important concepts
            - Lay out context map of project in BTW environment
    - Context Mapping of GTD domain
        - Podcast
            - Discuss context map homework
                - Explicit specifics of GTD environment
                    - OSS
                    - Potentially distributed team
                    - Limited time
                - Bounded contexts
                    - User Management and registration
                    - GTD
                - Subdomains
                    - Core Domain
                    - Client UIs
                    - APIs
                - Interactions
            - Figure out Ubiquituous language from the book
            - Identify behaviours and group them into aggregates
            - Lay out future plan
        - References:
            - Italian article on context mapping
        - Home work:
            - Come up with the DDD model expressed for dsL
            - Express a few stories in this DSL (e.g.
              specification-style)
    - Domain Modeling Process Revisited 
        - Prepare:                                                        Rinat
            - Start implementing A+ES block
        - Podcast
            - Reimplementation Sprint
                - Behavioral logic
                - Specifications
                - Interactive Shell
        - Home work:                                                      Kerry
            - Finish missing elements to have equivalent of Factory E017
    - First Application Server for our domain
        - Prepare: Deployed worker with some basics                       Rinat
            - Persistence: abstracted + files
            - Messaging: synchronous calls
            - Interactive shell for the server
        - Podcast:
            - Walk over the application server
                - Persistence
                - RPC + messaging
                - Maintenance
            - Potential bottlenecks
            - Delaying decisions
        - Home work:
            - ???
    - Lightweight Development a la Lokad (Split?)
        - Prepare:
            - Proper github project
            - Lightweight wiki
            - Documented workflow
            - Continuous Integration
        - Podcast:
            - Principle of replaceable "development architecture"
            - Issue trackers - github
            - git principles
            - Continuous Integration - Team City
            - Development principles
            - Major and minor releases
            - Documentation
            - Code ownership
            - Work distribution in similar project
            - Reviews
            - Continuous delivery
        - Home work:
            - Try running locally
            - Close a few issues on github
    - Continuous Delivery Process
        - Prepare:                                                        Rinat
            - Continuous deployments
            - Transparent view rebuilds
            - Implement isolated AddIns for GTD
        - Podcast:
            - Usual Server deployment story
            - Concepts of continuous deployment
                - Deployment branches
                - Moving changes and features around
                - Incremental changes
                - Server-side and infrastructure support
                - Projection management details
            - Downtime and no-downtime deployments
        - Homework:                                                       Kerry
            - Develop and deploy new functionality bit without
              restarting server
    - Deliver: First simple Web UI
        - Prepare:                                                        Rinat
            - Web UI skeleton with ASP.NET MVC
        - Podcast
            - Inductive and Task-based UI
            - Eventual consistency in UI
            - MVC Model
            - Implementation patterns
            - Deployment story
            - Scaling options
        - Homework:
            - Close a few UI-related tickets on github
    - Distributed Development
        - Prepare:
            - Plan for future deliveries
        - Podcast:
            - Principles of parallel and distributed development
            - Additional methodologies for planning and managing
              projects
            - We are actually going to try to run subsequent projects
              in parallel!
            - Mapping between real team collaboration and context map
            - Project roles:
                - Team lead
                - Developer
                - QA / Testing
                - Design
                - Content writer
                - // roles can be joined and mixed
            - Projects (not all will be implemented):
                - Occasionally connected desktop client
                - iOS native client
                - Windows Phone
                - Android client
                - Technological irrelevance
                - Cloud deployments
                - Rich web UI
        - Homework:
            - Figure out if you want to take some role in one of the
              projects
    - Deliver: Occasionally connected desktop client
        - Prepare:                                                        Rinat
            - Desktop UI prototype with embedded domain, sync and
              conflict resolution
        - Podcast:
            - Explore occasional connectivity
            - Conflict resolution
                - Automated
                - Manual
        - Homework:
            - Implement additional features in this field
    - Deliver: iOS native client on reused codebase
        - Prepare:                                                        ??? / Rinat
            - Building on the previous codebase, build something
              theoretically runnable on iOS (ideally an app)
        - Podcast:
            - Specifics of iOS development (interview Kerry)
            - MonoTouch
            - AppStore
        - Homework:
            - ???
    - Deliver: Windows Phone client
        - Prepare:                                                        Ufa?
            - Reuse codebase to deliver similar windows phone client
        - Podcast:
            - Talk about quirks of Windows Phone development
        - Homework
    - Deliver: Android Client
    - Deliver: rich HTML5 experience
        - Prepare:
            - Interactive single-page web client
        - Podcast:
            - HTML5 + CSS3
            - Tips and tricks
            - ASP.NET MVC
            - Twitter Bootstrap
            - jQuery
            - HTML templates
            - Accessing projections
            - Sending commands
            - Notifications
        - Homework:
            - Do github tickets related to this episode
    - Deliver: Technological Irrelevance
        - Prepare:                                                        Rinat / Greg
            - Adapt server to Greg's Event Store
        - Podcast:
            - Changing technology stacks for various adaptations
            - Explain the reasoning behind interfaces chosen for
              persistence
            - Sample stacks of adapters:
                - Greg's Event Store
                - Redis KVS
                - Windows Azure
                - Amazon
                - OpenCloud
            - Risk mitigation, scalability
        - Homework: 
            - Implement simple adapter for one of these stacks
    - Deliver: Cloud deployments and elastic scalability
        - Prepare:                                                        Rinat
            - Load balancer
            - Cloud-deployed server instance
        - Podcast:
            - Elastic scalability
            - Various scalability models
            - Upgrade process
        - Homework:
            - ???
