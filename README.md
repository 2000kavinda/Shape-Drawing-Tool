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
