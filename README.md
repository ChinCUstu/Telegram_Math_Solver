# Math Solver C# GUI

This is a C# GUI application that can automatically solve basic math problems on a web page and display the results in real-time. The application uses a `WebBrowser` control to load a math game website and extracts the necessary data from the web page to solve the math problems. The user can also enter the URL of the math game website manually.

The application supports the following math operators: addition, subtraction, multiplication, and division. Once the application has solved a math problem, it displays the original math problem along with the correct answer and the user's answer. If the user's answer is correct, the application automatically clicks the correct answer button on the web page. If the user's answer is incorrect, the application clicks the wrong answer button.

In addition to solving math problems on a web page, the application can also display the user's score in real-time in a separate window. The user's score is obtained by parsing messages from the Telegram Math Battle chat group using the Telegram Bot API. The application subscribes to the `OnMessage` event of the `TelegramBotClient` class and updates the user's score whenever a new message is received.

## Usage

To use the application, follow these steps:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Build and run the application.
4. Enter the URL of the math game website in the text box and click the "Go" button.
5. Solve the math problems by clicking the correct or wrong answer buttons.
6. View your score in the separate window.

## Dependencies

- .NET Framework 4.7.2

## Contributing

Contributions are welcome! If you find a bug or have a feature request, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the LICENSE file for details.
