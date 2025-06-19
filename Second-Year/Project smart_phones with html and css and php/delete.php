<?php
include 'db.php';

if (isset($_GET['id'])) {
    $id = $_GET['id'];

    // Delete the product from the database
    $delete_sql = "DELETE FROM products WHERE productID = ?";
    $stmt = $pdo->prepare($delete_sql);
    $stmt->execute([$id]);

    // Redirect back to the product list page
    header("Location: admin/product.php");
    echo "done delete";
    exit();
}
?>