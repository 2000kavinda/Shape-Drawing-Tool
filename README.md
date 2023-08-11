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

![Picture6](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/8f6a98e9-ff93-4f33-8935-6bb21b9a6e25)
![Picture7](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/59686b6e-e060-4714-b5ef-d9b59d71fbdd)
![Picture8](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/9bf2d397-4c85-4618-8d80-b434cbb34051)
![Picture9](https://github.com/2000kavinda/Shape-Drawing-Tool/assets/98000159/0bc60720-76f0-492b-ad29-c4f09370c286)
