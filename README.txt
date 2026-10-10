## Setup

This project will not work fully by simply cloning it — but if you just want to see the website's visuals, it will work seamlessly (just open the HTML files directly in a browser).

To get the full registration/login functionality working, you'll need to:

1. Create your own `appsettings.json` inside `BackEnd/BackEnd/` with your own MySQL credentials, port, and password.
2. Create a MySQL database named `account_management` (or update the database name in your connection string).
3. Run `dotnet ef database update` inside `BackEnd/BackEnd/` to create the required tables.
4. Run the backend project — note the port it starts on (shown in the terminal).
5. If the port differs from `7180`, update the `fetch()` URLs in `registrationPage.html` and `loginPage.html` to match.


FOR REFERENCE:
My Website focuses on teaching users on how to code. while w3 school and codechum exist (of course they're better im just doing this since its more easier to do.)
you will see many similarities of my teaching to theirs since the core idea and concepts in coding are universally the same
the only change you will notice is the "Wisdom Tree" feature, ill talk abt it in the features tab.

FEATURES:
- Dashboard for progress checking
- login/sign-in page for progress saving
- Wisdom Tree, a tree that grows depending on your mastered language or finished courses, every one starts as a seed, but the moment you finished your first language. It turns into your root/trunk, and as more languages you master, they will turn into the trees branches, with code challenges and achievements as the leaves

