<?php
include '../db.php'; // Include the database connection file

if (isset($_GET['id'])) {
    $id = $_GET['id'];

    // Delete the user from the database
    $sql = "DELETE FROM users WHERE userID = ?";
    $stmt = $pdo->prepare($sql);
    $stmt->execute([$id]);

    // Redirect to the users page after deletion
    header("Location: users.php");
    exit();
} else {
    echo "Invalid request.";
    exit();
}
?>