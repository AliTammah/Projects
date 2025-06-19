<?php
include 'db.php'; // Include the database connection file

// Fetch product details if ID is passed
$id = isset($_GET['id']) ? $_GET['id'] : null;
$product = null;

if ($id) {
    $stmt = $pdo->prepare("SELECT * FROM products WHERE productID = ?");
    $stmt->execute([$id]);
    $product = $stmt->fetch(PDO::FETCH_ASSOC);
}

// Handle form submission for updating product
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $id = $_POST['id'];
    $name = trim($_POST['name']);
    $model = trim($_POST['model']);
    $cost = trim($_POST['cost']);
    $ram = trim($_POST['ram']);
    $storage = trim($_POST['storage']);
    $color = trim($_POST['color']);
    $image = $_FILES['image1'];

    // Validate inputs
    $error = [];
    if (empty($name)) {
        $error['nameempty'] = "<div class='alert alert-danger'>Product name is required.</div>";
    }

    // If no errors, update the product
    if (empty($error)) {
        $update_sql = "UPDATE products SET pname = ?, pmodel = ?, pprice = ?, pram = ?, pstorage = ?, pcolor = ? WHERE productID = ?";
        $stmt = $pdo->prepare($update_sql);
        $stmt->execute([$name, $model, $cost, $ram, $storage, $color, $id]);

        // Handle image upload if a new image is provided
        if (!empty($image['name'])) {
            $target_dir = "uploads/";
            $target_file = $target_dir . basename($image['name']);
            move_uploaded_file($image['tmp_name'], $target_file);

            // Update the image in the database
            $update_image_sql = "UPDATE products SET image = ? WHERE productID = ?";
            $stmt = $pdo->prepare($update_image_sql);
            $stmt->execute([$image['name'], $id]);

        }

        // Redirect to the product list page
        header("Location: admin/product.php");
        exit();
    }
    header("Location: admin/product.php");

}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Edit Product</title>
    <!-- Include Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-7">
                <div class="card shadow">
                    <div class="card-header bg-primary text-white">
                        <h3 class="card-title text-center">Edit Product</h3>
                    </div>
                    <div class="card-body">
                        <?php   
                        // Display validation errors
                        if (!empty($error)) {
                            foreach ($error as $err) {
                                echo $err;
                            }
                        }
                        ?>
                        <form method="POST" action="<?php echo $_SERVER['PHP_SELF']; ?>" enctype="multipart/form-data">
                            <input type="hidden" name="id" value="<?= $product['productID'] ?>">
                            <div class="mb-3">
                                <label for="name" class="form-label">Product Name</label>
                                <input type="text" class="form-control" id="name" name="name" value="<?= $product['pname'] ?>" required>
                            </div>
                            <div class="mb-3">
                                <label for="model" class="form-label">Model</label>
                                <input type="text" class="form-control" id="model" name="model" value="<?= $product['pmodel'] ?>" required>
                            </div>
                            <div class="mb-3">
                                <label for="cost" class="form-label">Cost</label>
                                <input type="text" class="form-control" id="cost" name="cost" value="<?= $product['pprice'] ?>" required>
                            </div>
                            <div class="mb-3">
                                <label for="ram" class="form-label">RAM</label>
                                <input type="text" class="form-control" id="ram" name="ram" value="<?= $product['pram'] ?>" required>
                            </div>
                            <div class="mb-3">
                                <label for="storage" class="form-label">Storage</label>
                                <input type="text" class="form-control" id="storage" name="storage" value="<?= $product['pstorage'] ?>" required>
                            </div>
                            <div class="mb-3">
                                <label for="color" class="form-label">Color</label>
                                <input type="text" class="form-control" id="color" name="color" value="<?= $product['pcolor'] ?>" required>
                            </div>
                            <div class="mb-3">
                                <label for="image1" class="form-label">Product Image</label>
                                <input type="file" class="form-control" id="image1" name="image1">
                                <?php if (!empty($product['image'])): ?>
                                    <img src="../images/<?= $product['image'] ?>" alt="Product Image" width="100" class="mt-2">
                                <?php endif; ?>
                            </div>
                            <div class="d-grid gap-2">
                                <button type="submit" class="btn btn-primary">Update Product</button>
                                <a href="admin/users.php" class="btn btn-secondary">Cancel</a>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Include Bootstrap JS (optional) -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>