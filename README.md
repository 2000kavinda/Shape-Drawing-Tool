# Shape-Drawing-Tool

<h1>Scenario</h1>
<p>
You have been hired recently by a multi-national company to design and implement a tool that can draw various shapes for their newly constructed 3D printer that allows blind people to touch and feel drawings.  Your tool (client) should allow one to select a standard shapes from a drop down list or select text so it can be converted to Braille.  When a standard shape is selected, get the list of parameters related to the shape such as the radius and center for a circle, and compute the perimeter, so that the required dot amount can be determined. When Braille option is selected, number of dots should be counted to compute the required liquid. 
The computation must be done as a service and the client should access the service by way of HTTP/SOAP. </p>
<ul>
<li>Service should publish the list of supported shapes such as circle, triangle, and rectangle, and supported Braille characters.</li>
<li>The client should retrieve the list, load to a drop down list, select one, and request the required parameters from the service.</li>
<li>The service then should provide the list of parameter related to a shape or Braille text.</li>
<li>Client should then provide values, service must do the computation, send the results to the client application.</li>
</ul>
<p>You must design the service and client following the best practices, using design patterns, and implement using .NET framework. </p>
<br>
<h1>Solution Application</h1><br>
<a href="https://drive.google.com/file/d/1kUtb6zvhqyEdignBKspPL5oMjIYcbPxk/view?usp=sharing">Application running screen recorder</a>
<br><br>
<h2>Sequential diagram</h2>

![WhatsApp Image 2023-04-23 at 00 01 43](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/3fa85cc4-3fc3-40b6-8bce-f1d720c0e40d)

<h2>Class diagram</h2>

![WhatsApp Image 2023-05-07 at 15 32 34](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/48f06932-b007-4e78-adef-58126010b788)


<h2>Use case diagram</h2>

![Untitled Diagramsa drawio_page-0001](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/5cf0d60e-c592-4261-9bac-8b2b203a2301)

<h2>Application interfaces</h2>
<p>This is a standalone application and it helps to print Braille letters and standard shapes in 3D
manner(3D printer) and show the required dot amount and dot count. In screen show the print
view also. when this application developing we use best practices and client-server architecture.
</p>

![Picture2](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/d14cb1fa-1f6a-4cee-9cee-8cce6755a3b6)

This is the landing page. There are 2 options here: Standard Shapes and Braille Characters. Here We have even given the corresponding images for those two options to make it easier for the user. And for those two options, we have used red color background so that the attention is drawn immediately. Here, according to the option clicked by the user, he will be directed to respective page.
Navigation bar is located in left column of the interface. The navigation bar frequently remains visible on all displays, enabling the user to swiftly and effectively transition between pages.

![Picture3](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/a4070057-eb6e-469b-8fb7-2b8539d14511)

If the user selects the standard option on the home page, he will be directed to this page.
User can select the desired shape from the dropdown list here.

![Screenshot 2023-04-21 000352](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/091a8d14-f13f-452f-a7e5-66c434990de4)
![Screenshot 2023-04-21 000724](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/43c69114-001c-4e8f-9f44-c952c277960a)
![Screenshot 2023-04-21 000803](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/e8038620-1527-4378-8ba7-920b23ff1bf5)
![Screenshot 2023-04-21 000837](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/a95e2548-d00b-4b81-9dfe-fbaa0cb8953a)

Depending on the shape the user selects on the “Select a shape” page, he gets the relevant interface among these four interfaces.

![Screenshot 2023-04-21 000644](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/c2ccb4b8-ca2d-446f-b0ec-2a866677ca56)

If we assume that he chose the circle shape from dropdown list ,he will be directed to this page.
The user can enter the radius as the parameter related to the circle to the input field on below. After user submit it, the interface shows the required dot count and required ink liquid on top of the right side.
A Print view is also shown on the left so that the user can get an understanding of the relevant shape parameters. 
Similarly for other shapes, calculations can be done by entering the relevant parameters correctly.

![Screenshot 2023-04-21 000916](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/d8449c3b-06ff-4685-b1e3-9881941937a6)

If the user selects the standard option on the home page, he will be directed to this page.
The user can enter the text they want to convert into the text box in the area for entering text for conversion to Braille. There is a "Convert Text" button underneath the text box, which starts the converting process. The resulting Braille dots are shown in the black column once the conversion is complete. And The interface show the required dot count and required ink liquid on top of the right side.

![Screenshot 2023-04-21 000943](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/13c6c92d-1768-4336-86ba-5187728c4787)

When user selects the “About us” from navigation bar, he will be direct to this page. This page includes important information about this application. 
By reading this, the user can understand the factors such as the purpose of creating this application, the role played by it.

![Screenshot 2023-04-21 001016](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/afe3072c-27c7-421a-81b3-ea88efe52fb2)

When user selects the “Help” from navigation bar, he will be direct to this page. 
This page has detailed all the instructions required for the user to use this application.
This page is created to be user-friendly and simple with clear instructions to help users better understand how to use the application.

<h2>Architectural decisions</h2>

When we creating the Shape drawing tool , we mainly use client server architecture. The application divide into two parts called as the client component and server component. All the user interfaces and presentation logics are handled by the client component. And all the logical part of the application and the data processing parts are handled by the server component.

We used forms for create the front end development and we use service for the back end logic development. The server was implemented as a separate services , which is communicate with the clients through the user interfaces. As a example when we select the shapes option in our application, you need enter the parameters. Then all the. Logical part is done by the service and view the dot count and the required ink and the printed image in the interfaces. And lets think we select the braille letter option. Then you need to type the text and click the convert button. Then through the service, it convert the text to the braille characters and view in the Interfaces. 

When we develop the system by manage the server and the client separately, it helps to improve the modularity and scalability of the system. This method also provide several other benefits. 

For example, the system allows for more flexible deployment options, as the service can be hosted on a separate machine or in the cloud. And we can easily maintain the system and update the application logic independently of the user interface. So we can minimize downtime and improve overall system reliability through this. In this case service component is responsible for handling all the data operations.

![image](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/b541e850-ba84-4429-a382-d7e6b3284cfd)


