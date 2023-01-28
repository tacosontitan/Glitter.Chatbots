# 🗻 Welcome Aboard

Named after the second largest mountain in Norway, Glitter is a framework for quickly building out chatbots and the commands they can invoke.

![License](https://img.shields.io/github/license/tacosontitan/Glitter?logo=github&style=for-the-badge)
![Downloads](https://img.shields.io/nuget/dt/glitter?logo=nuget&style=for-the-badge)

## 💁‍♀️ Getting Started

Get started by reviewing the answers to the following questions:
- [How can I help?](./CONTRIBUTING.md)
- [How should I behave here?](./CODE_OF_CONDUCT.md)
- [How do I report security concerns?](./SECURITY.md)

### ✅ Small changes, continuously integrated

Glitter employs workflows for continuous integration to ensure the repository is held to industry standards; here's the current state of those workflows:

![.NET Workflow](https://img.shields.io/github/actions/workflow/status/tacosontitan/Glitter/dotnet.yml?label=Build%20and%20Test&logo=dotnet&style=for-the-badge)
![Analysis Workflow](https://img.shields.io/github/actions/workflow/status/tacosontitan/Glitter/codeql.yml?label=Analysis&logo=dotnet&style=for-the-badge)

### 📦 Available on NuGet

Glitter is available for consumption via NuGet:

![Version](https://img.shields.io/nuget/v/Glitter?logo=nuget&label=Glitter&style=for-the-badge)<br/>
![Version](https://img.shields.io/nuget/v/Glitter.Discord?logo=nuget&label=Glitter.Discord&style=for-the-badge)<br/>
![Version](https://img.shields.io/nuget/v/Glitter.Commands.OpenSource?logo=nuget&label=Glitter.Commands.OpenSource&style=for-the-badge)

### 💎 A few more gems

We believe in keeping the community informed, so here's a few more tidbits of information to satisfy some additional curiosities:

![Contributors](https://img.shields.io/github/contributors/tacosontitan/Glitter?logo=github&style=for-the-badge)
![Issues](https://img.shields.io/github/issues/tacosontitan/Glitter?logo=github&style=for-the-badge)
![Stars](https://img.shields.io/github/stars/tacosontitan/Glitter?logo=github&style=for-the-badge)
![Size](https://img.shields.io/github/languages/code-size/tacosontitan/Glitter?logo=github&style=for-the-badge)
![Line Count](https://img.shields.io/tokei/lines/github/tacosontitan/Glitter?logo=github&style=for-the-badge)

## 🪄 Working with Glitter

### 🎉 Create a Chatbot

It's never been easier to get a custom made chatbot up and running. Simply add a few lines of code to your `Program.cs` file to get started:
```csharp
using Glitter;
using Glitter.Commands.OpenSource;
using Glitter.Discord;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => services
        .AddGlitter()
        .AddOpenSourceCommands()
        .AddDiscord("<AUTH_TOKEN>")
).Build();
await host.RunAsync();
```
With that, you've got a working chatbot that can communicate with Discord; and all that's left is to add some custom commands!

## 💪 Powered by Open Source

The following open source projects help to power both Glitter and Freya; be sure to give them a star! ⭐
- [Mauve](https://github.com/tacosontitan/Mauve)
- [MediatR](https://github.com/jbogard/MediatR)
- [TwitchLib](https://github.com/TwitchLib/TwitchLib)

### 🎊 Open Source Commands

There are endless possibilities for chatbot commands! Glitter encourages the open-source community to create a vast global baseline of commands for public consumption. Here's our current baseline list of commands included with all Glitter powered bots:

- `help`: Queries for a list of commands.
- `version`: Queries for the current version of the bot.
- `uptime`: Queries the time the bot has been up and running.

Of course, these are just the commands that are automatically registered with your bot through `AddOpenSourceCommands`. You can manually register any open-source command just like you would a custom made one:
```csharp
services.AddGlitter(config => config.AddCommand<MySampleCommand>());
```

## 🧪 Tested by Open Source

The following open source projects help to keep Glitter tested and held to the highest standards; be sure to give them a star! ⭐
- [Fluent Assertions](https://github.com/fluentassertions/fluentassertions)
- [Fluent Validation](https://github.com/FluentValidation/FluentValidation)
- [Shouldly](https://github.com/shouldly/shouldly)
- [Coverlet](https://github.com/coverlet-coverage/coverlet)

## 🎨 Color Palette

![image](https://user-images.githubusercontent.com/65432314/213923346-1f909154-56e3-4fdd-ba8b-45c5b98a8c5e.png)
<p align="center"><sub><i>This color palette is subject to change.</i></sub></p>

## 💃 Freya

Freya is [tacosontitan's](https://github.com/tacosontitan) personal chatbot built using Glitter as a design pallete and proof of concept.

![Freya Header](/.resources/images/freya-header.png "Freya Header")
