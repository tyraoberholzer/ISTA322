# <center> ASP.NET Homework 03</c>

**Question 1**
What is the most important part of an ASP.NET Core 3 application?

**Answer**
The data model is the most important part.



**Question 2**
What is the domain model?

**Answer**
It contains the C# objects (known as domain objects) that make up the universe of the application and the methods that manipulate them.



**Question 3**
Where are the model classes in an ASP.NET Core 3 application placed?

**Answer**
The models folder.



**Question 4**
How many action methods can a controller class define?

**Answer**
As many as you need.



**Question 5**
What is a tag helper?

**Answer**
They enable server-side code to participate in creating and rendering HTML elements in Razor file. They are authored in C#, and they target HTML elements based on element name, attribute name, or parent tage.



**Question 6**
What does the asp-action attribut do?

**Answer**
It is an instruction to add an href attribute to the element that contains a URL for an action method.



**Question 7**
What is the difference between HTTP GET and HTTP POST? This is an important question, and you
should understand the difference.

**Answer**
A GET request is what a browser issues normally each time someone clicks a link. Post: forms rendered using Html.BeginForm() are submitted by the browser as a POST request.



**Question 8**
What is model binding?

**Answer**
Is a useful ASP.NET Core feature whereby incoming data is parsed and the key/value pairs in the HTTP request are used to populate properties of domain model types.



**Question 9**
Why should we validate user data? How do we validate user data?

**Answer**
If a user submits data that is not within the allowed values or it is in the wrong format, it may cause the application to exhibit unexpected behaviour - which may include blank screen or a screen that doesn't make sense. It can help to ensure the data stored is complete and nothing is missing.



**Question 10**
What, specifically, is the ModelState.IsValid property?

**Answer**
Tells you if any model errors have been added to ModelState. The default model binder will add some errors for basic type conversion issues.



**Question 11**
What does the asp-validation-summary do?

**Answer**
It is applied to a div element, and it displays a list of validation errors when the view is rendered.



**Question 12**
Static content consist of content such as images, script files, style files, etc. In an ASP.NET Core application, what is the name of the folder that containes static content?

**Answer**
It is the wwwroot folder.



**Question 13**
What is Bootstrap? Who developed Bootstrap? Is Bootstrap a proprietary packages? If not, What is it?

**Answer**
It defines classes that can be usd to style forms.
Is a free and open-source CSS framework directed at responsive, mobile-first front-en web development. It contains CSS and JavaScript based design template for typography, form, button, navigation, and other interface components. Mark Otto, Jacob Thornton Orignally developed by twitter.
