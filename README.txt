## Setup

This project will not work fully by simply cloning it — but if you just want to see the website's visuals, it will work seamlessly (just open the HTML files directly in a browser).

To get the full registration/login functionality working, you'll need to:

1. Create your own `appsettings.json` inside `BackEnd/BackEnd/` with your own MySQL credentials, port, and password.
2. Create a MySQL database named `account_management` (or update the database name in your connection string).
3. Run `dotnet ef database update` inside `BackEnd/BackEnd/` to create the required tables.
4. Run the backend project — note the port it starts on (shown in the terminal).
5. If the port differs from `7180`, update the `fetch()` URLs in `registrationPage.html` and `loginPage.html` to match.
