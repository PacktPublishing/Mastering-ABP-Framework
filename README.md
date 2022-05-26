## [Get this title for $10 on Packt's Spring Sale](https://www.packt.com/B17287?utm_source=github&utm_medium=packt-github-repo&utm_campaign=spring_10_dollar_2022)
-----
For a limited period, all eBooks and Videos are only $10. All the practical content you need \- by developers, for developers

# Mastering ABP Framework
Mastering ABP Framework, published by Packt

<a href="https://www.packtpub.com/product/mastering-abp-framework/9781801079242"><img src="https://static.packt-cdn.com/products/9781801079242/cover/smaller" alt="Mastering ABP Framework" height="256px" align="right"></a>

This is the code repository for [Mastering ABP Framework](https://www.packtpub.com/product/mastering-abp-framework/9781801079242), published by Packt.

**Build maintainable .NET solutions by implementing software development best practices**

## What is this book about?
ABP Framework is a complete infrastructure for creating modern web applications. This easy-to-follow guide is for anyone who wants to learn how to use ABP Framework for building robust, maintainable, and scalable software solutions by implementing best practices and using state-of-the-art technologies and tools.

This book covers the following exciting features: 
* Set up the development environment and get started with ABP Framework
* Work with Entity Framework Core and MongoDB to develop your data access layer
* Understand cross-cutting concerns and how ABP automates repetitive tasks
* Get to grips with implementing domain-driven design with ABP Framework
* Build UI pages and components with ASP.NET Core MVC (Razor Pages) and Blazor
* Work with multi-tenancy to create modular web applications

If you feel this book is for you, get your [copy](https://www.amazon.com/dp/1801079242) today!

<a href="https://www.packtpub.com/?utm_source=github&utm_medium=banner&utm_campaign=GitHubBanner"><img src="https://raw.githubusercontent.com/PacktPublishing/GitHub/master/GitHub.png" alt="https://www.packtpub.com/" border="5" /></a>

## Instructions and Navigations
All of the code is organized into folders.

The code will look like the following:
```
public override void Define(IPermissionDefinitionContext context)
{
    var myGroup = context.AddGroup(
        "ProductManagement",
        L("ProductManagement"));
    var parent = myGroup.AddPermission(
        "MyParentPermission");
    parent.AddChild("MyChildPermission");
}


```
**Following is what you need for this book:**

ABP Framework is a complete infrastructure for creating modern web applications by following software development best practices and conventions. With ABP's high-level framework and ecosystem, you can implement the Don’t Repeat Yourself (DRY) principle and focus on your business codes.

With the following software and hardware list you can run all code files present in the book (Chapter 1-17).

### Software and Hardware List

We will be building an application, so you need to have .NET runtime, ABP CLI, and an IDE/editor installed to build ASP.NET Core projects

### Related products <Other books you may enjoy>
* Web Development with Blazor [[Packt]](https://www.packtpub.com/product/web-development-with-blazor/9781800208728) [[Amazon]](https://www.amazon.com/Web-Development-Blazor-NET-hands/dp/1800208723)

* Customizing ASP.NET Core 6.0 [[Packt]](https://www.packtpub.com/product/customizing-asp-net-core-6-0-second-edition/9781803233604) [[Amazon]](https://www.amazon.com/Customizing-ASP-NET-Core-6-0-applications-dp-1803233605/dp/1803233605/ref=mt_other?_encoding=UTF8&me=&qid=)

## Get to Know the Author
**Halil İbrahim Kalkan** is a computer engineer who loves building reusable libraries, creating distributed solutions, and working on software architectures. He is an expert on Domain Driven Design, Multi-Tenancy, Modularity and Microservice Architecture. Halil has been building software since 1997 (when he was 14) and working as a professional since 2007. He has a lot of articles and talks on software development. He is a very active open-source contributor and built many projects based on the web and Microsoft Technologies. Halil is currently leading the open-source ABP Framework, which provides a complete architectural solution and the necessary infrastructure to implement that architecture.
