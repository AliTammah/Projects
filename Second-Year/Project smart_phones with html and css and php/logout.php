<?php
session_start(); // Start the session
session_unset(); // Unset all session variables
session_destroy(); // Destroy the session
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Logout</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f8ff;
            text-align: center;
            padding: 50px;
        }
        .logout-container {
            background: white;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            max-width: 400px;
            margin: auto;
        }
        .logout-container h2 {
            color: #333;
        }
        .logout-container a {
            display: inline-block;
            margin-top: 20px;
            padding: 10px 20px;
            text-decoration: none;
            color: white;
            background: #28a745;
            border-radius: 5px;
        }
        .logout-container a:hover {
            background: #218838;
        }
    </style>
</head>
<body>

<div class="logout-container">
    <h2>You have been logged out.</h2>
    <p>Click below to log in again.</p>
    <a href="admin/login.php">Go to Login</a>
</div>

</body>
</html>
