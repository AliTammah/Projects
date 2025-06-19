<?php
session_start(); // بدء الجلسة

$error = ''; // لتخزين رسائل الخطأ

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $email = trim($_POST['email']);
    $password = trim($_POST['password']);

    // التحقق من البريد الإلكتروني وكلمة المرور
    if (empty($email) || empty($password)) {
        $error = "Please fill in all fields.";
    } else {
        include '../db.php'; // تضمين ملف الاتصال بقاعدة البيانات

        // البحث عن المستخدم في قاعدة البيانات
        $sql = "SELECT * FROM users WHERE email = :email";
        $stmt = $pdo->prepare($sql);
        $stmt->execute(['email' => $email]);
        $user = $stmt->fetch(PDO::FETCH_ASSOC);

        if ($user) {
            // التحقق من كلمة المرور
            if ($password == $users['password']) { // يمكن استبدالها بـ password_verify إذا كنت تستخدم التشفير
                $_SESSION['user_id'] = $user['userID'];
                $_SESSION['role'] = $user['role'];

                // توجيه المستخدم بناءً على الدور
                if ($user['role'] == 1) {
                    header("Location: index.php"); // لوحة تحكم المدير
                } else {
                    header("Location: ../index.php"); // لوحة تحكم المستخدم العادي
                }
                exit();
            } else {
                $error = "Invalid password.";
            }
        } else {
            $error = "User not found.";
        }
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login Page</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <style>
        body {
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
        }
        .login-box {
            background: #fff;
            padding: 2rem;
            border-radius: 10px;
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.2);
            width: 100%;
            max-width: 400px;
        }
        .login-box h2 {
            margin-bottom: 1.5rem;
            color: #333;
            text-align: center;
        }
        .form-control {
            border-radius: 5px;
            padding: 0.75rem;
        }
        .btn-primary {
            width: 100%;
            padding: 0.75rem;
            border-radius: 5px;
            background: #2575fc;
            border: none;
        }
        .btn-primary:hover {
            background: #1a5bbf;
        }
        .links {
            margin-top: 1rem;
            text-align: center;
        }
        .links a {
            color: #2575fc;
            text-decoration: none;
        }
        .links a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>

    <div class="login-box">
        <h2>Login</h2>
        <?php if (!empty($error)): ?>
            <div class="alert alert-danger"><?php echo $error; ?></div>
        <?php endif; ?>
        <form action="<?php echo htmlspecialchars($_SERVER['PHP_SELF']); ?>" method="POST">
            <div class="mb-3">
                <label for="email" class="form-label">Email</label>
                <input type="email" class="form-control" id="email" name="email" >
            </div>
            <div class="mb-3">
                <label for="password" class="form-label">Password</label>
                <input type="password" class="form-control" id="password" name="password" >
            </div>
            <button type="submit" class="btn btn-primary">Login</button>
        </form>
        <div class="links mt-3">
            <a href="forgot_password.php">Forgot Password?</a> | 
            <a href="../account.php">Create New Account</a>
        </div>
    </div>

</body>
</html>