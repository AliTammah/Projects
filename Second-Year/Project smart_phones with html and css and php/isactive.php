<?php
include 'db.php';

if (isset($_GET['id'])) {
    $id = $_GET['id'];

    // جلب الحالة الحالية للنشاط
    $stmt = $pdo->prepare("SELECT active FROM products WHERE productID = ?");
    $stmt->execute([$id]);
    $product = $stmt->fetch(PDO::FETCH_ASSOC);

    // تبديل الحالة (Active/Inactive)
    $new_status = $product['active'] ? 0 : 1;

    // تحديث الحالة في قاعدة البيانات
    $update_sql = "UPDATE products SET active = ? WHERE productID = ?";
    $stmt = $pdo->prepare($update_sql);
    $stmt->execute([$new_status, $id]);

    // إرجاع بيانات JSON
    echo json_encode([
        'status' => 'success',
        'new_status' => $new_status,
        'button_text' => $new_status ? 'Active' : 'Inactive',
        'button_class' => $new_status ? 'btn-success' : 'btn-danger'
    ]);
    header("Location: admin/product.php");

    // exit();
} else {
    // echo json_encode(['status' => 'error', 'message' => 'Invalid request']);
    header("Location: admin/product.php");

    exit();
}
?>
