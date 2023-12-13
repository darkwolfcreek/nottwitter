# NotTwitter README

![NotTwitter Logo](https://i.imgur.com/sqLZbcO.png)

## Introduction
Welcome to NotTwitter, a Blazor Server-based web application designed for creating and viewing posts. This platform offers an interactive way for users to share and engage with content, utilizing .NET 7 and PostgreSQL for efficient and secure data management.

## Features
- **Post Creation:** Users can create posts with details like username, content, mood, and topic.
- **Interactive Feed:** The application showcases a dynamic feed of posts with relevant details.
- **User Engagement:** Designed for easy interaction and browsing of posts.

## Requirements
- .NET 7
- PostgreSQL
- Blazor Server

## Installation
1. Clone the repository to your local environment.
2. Ensure you have a PostgreSQL database setup.
3. Open the project in an IDE such as Visual Studio and run the application.

## Configuration
**Security Notice:** It's highly recommended to use environment variables for database connection settings to enhance security. Avoid hardcoding sensitive information in your source code.

### Setting up Environment Variables
Create a `.env` file or set environment variables directly in your system for your database credentials. Your application should be configured to read these variables for establishing database connections.

Example in `.env` file:
```
DB_HOST=your_database_host
DB_PORT=your_database_port
DB_NAME=your_database_name
DB_USER=your_database_username
DB_PASSWORD=your_database_password
```

Adapt your application's database connection logic to utilize these environment variables.

## Usage
- **Creating a Post:** Navigate to the post creation section, fill in the details, and submit.
- **Viewing Posts:** Browse through the latest posts on the home page.

## Contributing
Your contributions make NotTwitter better. Fork the repository, make your changes, and submit a pull request for review.

## License
This project is released under the MIT License. See the LICENSE file for more information.

## Support
For support and queries, please open an issue on the GitHub repository or contact via provided email.

## Acknowledgments
- The .NET 7 and Blazor Server frameworks
- Npgsql for PostgreSQL integration
- Contributions from the developer community
