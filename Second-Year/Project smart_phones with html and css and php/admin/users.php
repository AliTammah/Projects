<?php
include '../db.php';

$error = []; // Initialize error array

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $fname = trim($_POST['fname']);
    $lname = trim($_POST['lname']);
    $email = trim($_POST['email']);
    $password = trim($_POST['password']);
    $address = trim($_POST['address']);
    $phone = trim($_POST['phone']);
    $role = trim($_POST['role']);
    $image = $_FILES['image'];

    // Validate inputs
    if (empty($fname)) {
        $error['fnameempty'] = "<h5 style='color:red'>Sorry, first name is required</h5>";
    } elseif (is_numeric($fname)) {
        $error['fnameinteger'] = "<h5 style='color:red'>Sorry, name must be a string</h5>";
    }

    if (empty($lname)) {
        $error['lnameempty'] = "<h5 style='color:red'>Sorry, last name is required</h5>";
    } elseif (is_numeric($lname)) {
        $error['lnameinteger'] = "<h5 style='color:red'>Sorry, name must be a string</h5>";
    }

    if (empty($email)) {
        $error['email_empty'] = "<h5 style='color:red'>Sorry, email is required</h5>";
    } elseif (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        $error['email_invalid'] = "<h5 style='color:red'>Invalid email format</h5>";
    }

    if (empty($address)) {
        $error['address_empty'] = "<h5 style='color:red'>Address is required</h5>";
    }

    if (empty($password)) {
        $error['pass_empty'] = "<h5 style='color:red'>Password is required</h5>";
    }
    //elseif (!preg_match('/^(?=.*\d)(?=.*[A-Za-z])[0-9A-Za-z]{8,}$/', $password)) {
    //     $error['pass_string'] = "<h4 style='color:red'>Password must contain at least one letter and one number</h4>";
    // }

    if (empty($phone)) {
        $error['phone_empty'] = "<h5 style='color:red'>Phone is required</h5>";
    } elseif (!is_numeric($phone)) {
        $error['phone_string'] = "<h4 style='color:red'>Phone must be a number</h4>";
    }

    if (empty($role)) {
        $error['role_empty'] = "<h5 style='color:red'>Role is required</h5>";
    }

    // Validate image
    if (empty($image['name'])) {
        $error['image_empty'] = "<h5 style='color:red'>Image is required</h5>";
    } else {
        $image = $_FILES['image']['name'];
        $types = array("jpg", "png", "jpeg", "gif");
        $exit = explode(".", $image);
        $exit = end($exit);
        $exit = strtolower($exit);

        // if (!in_array($exit, $types)) {
        //     $error['image_type'] = "<h5 style='color:red'>The image type is invalid</h5>";
        // } elseif ($image['size'] > 2000000) { // 2MB in bytes
        //     $error['image_size'] = "<h5 style='color:red'>The image size must be less than 2MB</h5>";
        // }
    }

    // If no errors, proceed with insertion
    if (empty($error)) {
        $target_dir = "uploads/"; // Directory where the image will be saved
        $target_file = $target_dir . basename($_FILES['image']['name']); // Full path to the file
        $uploadOk = 1; // Flag to check if the upload is successful
        $imageFileType = strtolower(pathinfo($target_file, PATHINFO_EXTENSION)); // Get the file extension
        // Check for duplicate email
        $check_sql = "SELECT * FROM users WHERE email = :x1";
        $check_stmt = $pdo->prepare($check_sql);
        $check_stmt->execute(array('x1' => $email));

        if ($check_stmt->rowCount() == 0) {
            // $hashed_password = password_hash($password, PASSWORD_DEFAULT);
            $insert = "INSERT INTO users (first_name, last_name, phone, email, password, address, role, image) 
                       VALUES (:x1, :x2, :x3, :x4, :x5, :x6, :x7, :x8)";
            $sql = $pdo->prepare($insert);

            try {
                $sql->execute(array(
                    'x1' => $fname,
                    'x2' => $lname,
                    'x3' => $phone,
                    'x4' => $email,
                    'x5' => $password,
                    'x6' => $address,
                    'x7' => $role,
                    'x8' => $image
                ));
                header("Location: users.php");
                exit();
            } catch (PDOException $e) {
                echo "Error: " . $e->getMessage();
            }
        } else {
            $error['duplicate'] = "<h5 style='color:red;'>User with this email already exists</h5>";
        }
    }
}

// Display errors
if (!empty($error)) {
    foreach ($error as $err) {
        echo $err;
    }
}
?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Admin Control Panel</title>
    <!-- BOOTSTRAP STYLES-->
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
    <!-- FONTAWESOME STYLES-->
    <link href="assets/css/font-awesome.css" rel="stylesheet" />
    <!-- MORRIS CHART STYLES-->
    <link href="assets/js/morris/morris-0.4.3.min.css" rel="stylesheet" />
    <!-- CUSTOM STYLES-->
    <link href="assets/css/custom.css" rel="stylesheet" />
    <!-- GOOGLE FONTS-->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
    <link rel="icon" href="../../../images/icon.jpg" sizes="16x16" type="image/jpg">
</head>

<body>
    <div id="wrapper">
        <nav class="navbar navbar-default navbar-cls-top" role="navigation" style="margin-bottom: 0px">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" style="background-color: #e5b68a;" href="index.php">Control panel</a>
            </div>
            <!-- <label style="margin-right:40px;color:white;margin-left:800px;margin-top:18px;">Welcome User</label> -->
            <div style="color: white; padding: 15px 50px 5px 50px; float: right; font-size: 16px; display:flex;">
                <a href="../index.php" style="background-color: #e5b68a;"
                    class="btn btn-success square-btn-adjust">Logout</a>
            </div>
        </nav>
        <nav class="navbar-default navbar-side" role="navigation">
            <div class="sidebar-collapse">
                <ul class="nav" id="main-menu" style="background-color: #f6f6f6;">
                    <li>
                        <a href="index.php"><i class="fa fa-dashboard"></i> Control panel</a>
                    </li>
                    <li>
                        <a href="users.php"><i class="fa fa-users"></i> Users</a>
                    </li>
                    <li>
                        <a href="categories.php"><i class="fa fa-tasks"></i> Categories</a>
                    </li>
                    <li>
                        <a href="product.php"><i class="fa fa-bars"></i> phones</a>
                    </li>
                </ul>
            </div>
        </nav>

        <div id="page-wrapper">
            <div id="page-inner">
                <div class="row">
                    <div class="col-md-12">
                        <h2><i class="fa fa-users"></i> Users</h2>
                    </div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-8">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <i class="fa fa-plus-circle"></i> Add New User
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-md-12">
                                        <form action="<?php echo $_SERVER['PHP_SELF']; ?>" role="form"
                                            enctype="multipart/form-data" method="POST">
                                            <div class="form-group">
                                                <input type="hidden" name="user_id" value="">
                                                <label>first name</label>
                                                <input type="text" placeholder="Please Enter your Name"
                                                    class="form-control" name="fname">
                                                <?php
                                                if (isset($error['fnameempty'])) {
                                                    echo $error['fnameempty'];
                                                } elseif (isset($error['fnameinteger'])) {
                                                    echo $error['fnameinteger'];
                                                }

                                                ?>
                                                <label>last name</label>
                                                <input type="text" placeholder="Please Enter your Name"
                                                    class="form-control" name="lname">
                                                <?php
                                                if (isset($error['lnameempty'])) {
                                                    echo $error['lnameempty'];
                                                } elseif (isset($error['lnameinteger'])) {
                                                    echo $error['lnameinteger'];
                                                }

                                                ?>

                                            </div>
                                            <div class="form-group">
                                                <label>Email</label>
                                                <input type="email" placeholder="Please Enter your Email"
                                                    class="form-control" name="email">
                                            </div>
                                            <?php
                                            if (isset($error['email_empty'])) {
                                                echo $error['email_empty'];
                                            } elseif (isset($error['email_number'])) {
                                                echo $error['email_number'];
                                            }

                                            ?>
                                            <div class="form-group">
                                                <label>User Image</label><br>
                                                <img src="../../../images/default.jpg" alt="User Image"
                                                    style="border: none; width: 100px; border-radius: 50px; height: 100px; object-fit: fill;">
                                                <input type="file" class="form-control" name="image">
                                                <?php
                                                if (isset($error['image_empty'])) {
                                                    echo $error['image_empty'];
                                                }

                                                ?>
                                            </div>
                                            <div class="form-group">
                                                <label>Password</label>
                                                <input type="password" class="form-control"
                                                    placeholder="Please Enter password" name="password">

                                                <?php
                                                if (isset($error['pass_empty'])) {
                                                    echo $error['pass_empty'];
                                                }
                                                // elseif(isset( $error['pass_number'])){
                                                //     echo  $error['pass_number'];
                                                // }
                                                
                                                ?>
                                            </div>
                                            <div class="form-group">
                                                <label>Address</label>
                                                <input type="text" class="form-control"
                                                    placeholder="Please Enter address" name="address">
                                            </div>
                                            <?php
                                            if (isset($error['address_empty'])) {
                                                echo $error['address_empty'];
                                            }
                                            ?>
                                            <div class="form-group">
                                                <label>Phone</label>
                                                <input type="tel" class="form-control"
                                                    placeholder="Please Enter your phone" name="phone">
                                            </div>
                                            <?php
                                            if (isset($error['phone_empty'])) {
                                                echo $error['phone_empty'];
                                            } elseif (isset($error['phone_string'])) {
                                                echo $error['phone_string'];
                                            }
                                            ?>
                                            <div class="form-group">
                                                <label>User Type</label>
                                                <select class="form-control" name="role">
                                                    <option value="1">Admin</option>
                                                    <option value="2">User</option>
                                                    <?php
                                                    if (isset($error['role_empty'])) {
                                                        echo $error['role_empty'];
                                                    }
                                                    ?>

                                                </select>

                                            </div>
                                            <div style="float:right;">
                                                <button type="submit" class="btn btn-primary">Add User</button>
                                                <button type="reset" class="btn btn-danger">Cancel</button>
                                            </div>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <i class="fa fa-users"></i> Users
                            </div>
                            <div class="panel-body">
                                <div class="table-responsive">
                                    <table class="table table-striped table-bordered table-hover"
                                        id="dataTables-example">
                                        <thead>
                                            <tr>
                                                <th>First Name</th>
                                                <th>Last Name</th>
                                                <th>Email</th>
                                                <th>Password</th>
                                                <th>Address</th>
                                                <th>Phone</th>
                                                <th>Role</th>
                                                <th>Image</th>
                                                <th>Action</th>
                                            </tr>
                                        </thead>
                                        <?php
                                        $stmt = $pdo->query("SELECT * FROM users");
                                        $users = $stmt->fetchAll(PDO::FETCH_ASSOC);
                                        ?>
                                       <tbody>
            <?php foreach ($users as $user): ?>
            <tr>
                <td><?= $user['first_name'] ?></td>
                <td><?= $user['last_name'] ?></td>
                <td><?= $user['email'] ?></td>
                <td><?= $user['password'] ?></td>
                <td><?= $user['address'] ?></td>
                <td><?= $user['phone'] ?></td>
                <td><?= $user['role'] == 1 ? 'Admin' : 'Regular User' ?></td>
                <td><img src="images/<?= $user['image'] ?>" width="50"></td>
                <td>
                    <a href="edit_user.php?id=<?= $user['userID'] ?>" class='btn btn-success'>Edit</a>
                    <a href="delete_user.php?id=<?= $user['userID'] ?>" onclick="return confirm('Are you sure you want to delete this user?')" class='btn btn-danger'>Delete</a>
                </td>
            </tr>
            <?php endforeach; ?>
        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <script src="assets/js/jquery-1.10.2.js"></script>
                <script src="assets/js/bootstrap.min.js"></script>
                <script src="assets/js/jquery.metisMenu.js"></script>
                <script src="assets/js/morris/raphael-2.1.0.min.js"></script>
                <script src="assets/js/morris/morris.js"></script>
                <script src="assets/js/custom.js"></script>
            </div>
        </div>
    </div>
</body>

</html>