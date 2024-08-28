<h2>TECHINCAL CHOICES:</h2>

I created a ASP.NET Core backend. I chose this because it is a widely used technology for creating APIs and since I'm experienced with C#
<h2>INSTRUCTIONS:</h2>  
1. Extract the ZIP file<br><br>
2a. Open the project in Visual Studio or another IDE <br>
-Press F5 to run Start the Application. The website should open in a browser automatically <br><br>

2b. Alternatively: <br>
-Open a terminal such as cmd.exe <br>
-Navigate to the project directory <br>
-Run the program by entering: dotnet run program.cs <br>
-Copy the localhost adress from the terminal and navigate to http://localhost:XXXX/swagger in a web browser <br><br>
3. On the website, click on "Textfile" <br>
-Click on "Try It Out" <br>
-Upload a File and Click Execute <br><br>
The modified text now appears in the Response Body

<h2>Deployment</h2>
The web app is deployed and can be reachet at: https://foobartextprocessor.azurewebsites.net/swagger/ <br>
The application can easily be deployed since it is a standard API. I deployed it to an Azure App Service with continous deployement from github <br>

<h2>Questions</h2>
1. About 3 hours on the application itself, after which it worked locally. Two more hours to write this document as well as deploying the app <br><br>
2. The structure is simple since there is only one straightforward function in the API. The function: <br>
-reads the text from the file into a string <br>
-Counts the words in the string and finds the most used word. <br>
-Edits the string by inserting foo+bar around each occurence of that word <br>
-returns the string <br>
With comments explaining each step. <br><br>

I used regex when finding and counting words as well as when inserting foo+bar since it let me write succinct code while it also: <br>
*Avoids counting numbers, punctuation or whitespace as words <br>
*Inserts foo+bar around a word while not changing letter case in the word <br>
*Finds every occurence of the word regardless of letter case or nearby punctuation <br><br>
3. I would add error handling to provide the user with feedback in situation where the API doesn't return a good result such as: <br>
Trying to access the API without providing a file  <br>
*Uploading a non-text file or a file that isn't read correctly such as a PDF  <br>
*Trying to upload a file that's too large and can't be processed in a timely matter  <br>
*Connection problems  <br>

I would also create a frontend if i had more time  <br> <br>
4. It was an interesting task. It seems easy but it took some time to ensure that you don't get unexpected results due to counting whitespace or symbols as words, counting occurences of the same word separately due to letter case etc.






