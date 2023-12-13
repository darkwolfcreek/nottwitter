# NotTwitter README

![NotTwitter Logo](https://i.imgur.com/sqLZbcO.png)

## Introduction
NotTwitter is a web application for creating and viewing posts, designed with a focus on simplicity and user interaction. It leverages Blazor for the front-end and PostgreSQL for data management.

## Features
- **Create Posts:** Users can easily create posts with options like username, mood, topic, and profile picture URL.
- **View Posts:** Browse through a feed of posts, each displaying the user's mood, topic, and the time of posting.
- **User-Friendly Interface:** A streamlined interface for an enjoyable user experience.

## Requirements
- .NET 7.0 or higher
- PostgreSQL
- Blazor Server

## Installation
1. Clone the repository.
2. Set up a PostgreSQL database.
3. Run the application in an IDE like Visual Studio.

## Configuration
**Important:** For security reasons, it's advised to use environment variables instead of hardcoding the connection settings. This prevents sensitive data from being exposed in your codebase.

To configure your database connection using environment variables:
1. Set environment variables for your database credentials.
2. Modify the application to read these variables.

Example (in .env file):
```
DB_HOST=your_host
DB_PORT=your_port
DB_NAME=your_db
DB_USER=your_username
DB_PASSWORD=your_password
```

In your code, access these variables instead of hardcoding the credentials.

## Usage
- **To Create a Post:** Fill the form and submit.
- **To View Posts:** Posts are displayed on the homepage.

## Contributing
Contributions are welcome. Please fork the repo, make your changes, and submit a pull request.

## License
MIT License - see LICENSE file for details.

## Support
For support, email or open an issue on the GitHub repository.

## Acknowledgments
- Blazor
- Npgsql
- Community Contributions
