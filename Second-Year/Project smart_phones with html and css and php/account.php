<?php
include 'include/header.php'; // تأكد من أن هذا الملف يحتوي على اتصال بقاعدة البيانات
include 'db.php';
// معالجة البيانات عند إرسال النموذج
if ($_SERVER['REQUEST_METHOD'] == 'POST' && isset($_POST['createaccount'])) {
    // استخراج البيانات من النموذج
    $name = trim($_POST['name']);
    $email = trim($_POST['email']);
    $phone = trim($_POST['phone']);
    $address = trim($_POST['address']);
    $password = trim($_POST['pass']);

    // التحقق من عدم وجود بيانات فارغة
    if (empty($name) || empty($email) || empty($phone) || empty($address) || empty($password)) {
        $error = "Please fill in all fields.";
    } else {
        // التحقق من أن البريد الإلكتروني غير مستخدم مسبقًا
        $check_sql = "SELECT * FROM accounts WHERE email = :email";
        $check_stmt = $pdo->prepare($check_sql);
        $check_stmt->execute(['email' => $email]);

        if ($check_stmt->rowCount() > 0) {
            $error = "Email already exists.";
        } else {
            // إدخال البيانات في جدول الحسابات
            $insert_sql = "INSERT INTO accounts (name,phone, email, address, password) 
                           VALUES (:name,:phone, :email, :address, :password)";
            $insert_stmt = $pdo->prepare($insert_sql);

            try {
                $insert_stmt->execute([
                    'name' => $name,
                    'phone' => $phone,
                    'email' => $email,
                    'address' => $address,
                    'password' => $password 
                ]);
                $success = "Account created successfully!";
            } catch (PDOException $e) {
                $error = "Error: " . $e->getMessage();
            }
        }
    }
}
?>

<!-------------------- account page ----------->
<div class="account-page">
    <div class="container">
        <div class="row">
            <div class="col-2">
                <img src="images/LG2.jpg" width="100%">
            </div>
            <div class="col-2">
                <div class="form-container" style="height: 500px; overflow:auto;">
                    <div class="form-btn">
                        <span>Create Account</span>
                    </div>
                    <?php if (isset($error)): ?>
                        <div class="alert alert-danger"><?php echo $error; ?></div>
                    <?php endif; ?>
                    <?php if (isset($success)): ?>
                        <div class="alert alert-success"><?php echo $success; ?></div>
                    <?php endif; ?>
                    <form action="<?php echo htmlspecialchars($_SERVER['PHP_SELF']); ?>" method="POST">
                        <input type="text" placeholder="Name" name="name" >
                        <br>
                        <input type="text" placeholder="Email" name="email" >
                        <br>
                        <input type="tel" placeholder="Phone" name="phone" >
                        <br>
                        <input type="text" placeholder="Address" name="address" >
                        <br>
                        <input type="password" placeholder="Password" name="pass" >
                        <br>
                        <input type="submit" class="btn" name="createaccount" value="Create Account">
                        <br>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>

<!-------------------- Footer ----------------------->
<?php
include 'include/footer.php';
?>
</body>
</html>