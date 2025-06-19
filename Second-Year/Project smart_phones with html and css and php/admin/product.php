<?php
include '../db.php';

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $color = $_POST['color'];
    $name = trim($_POST['tname']);
    $model = trim($_POST['model']);
    $cost = trim($_POST['cost']);
    $ram = trim($_POST['ram']);
    $storage = trim($_POST['storage']);
    $product_image = $_FILES['image1'];

    // التحقق من الحقول المطلوبة
    if (empty($name)) {
        $error['nameempty'] = "<h5 style='color:red'>Sorry, name is required</h5>";
    } elseif (is_numeric($name)) {
        $error['nameinteger'] = "<h5 style='color:red'>Sorry, name must be a string</h5>";
    }

    if (empty($color)) {
        $error['colorempty'] = "<h5 style='color:red'>Sorry, color is required</h5>";
    } elseif (is_numeric($color)) {
        $error['color_number'] = "<h5 style='color:red'>Sorry, color must be a string</h5>";
    }

    if (empty($model)) {
        $error['model_empty'] = "<h5 style='color:red'>Model is required</h5>";
    }

    if (empty($cost)) {
        $error['cost_empty'] = "<h5 style='color:red'>Cost is required</h5>";
    } elseif (!is_numeric($cost)) {
        $error['cost_string'] = "<h4 style='color:red'>Cost must be a number</h4>";
    }

    if (empty($ram)) {
        $error['ram_empty'] = "<h5 style='color:red'>RAM is required</h5>";
    } elseif (!is_numeric($ram)) {
        $error['ram_string'] = "<h4 style='color:red'>RAM must be a number</h4>";
    }

    if (empty($storage)) {
        $error['storage_empty'] = "<h5 style='color:red'>Storage is required</h5>";
    } elseif (!is_numeric($storage)) {
        $error['storage_string'] = "<h4 style='color:red'>Storage must be a number</h4>";
    }

    // التحقق من الصورة
    if (empty($product_image['name'])) {
        $error['image_empty'] = "<h5 style='color:red'>Image is required</h5>";
    } else {
        $name_image = $_FILES['image1']['name'];
        $types = array("jpg", "png", "jpeg", "gif");
        $exit = explode(".", $name_image);
        $exit = end($exit);
        $exit = strtolower($exit);

        if (!in_array($exit, $types)) {
            $error['image_type'] = "<h5 style='color:red'>The image type is invalid</h5>";
        } elseif ($_FILES['image1']['size'] > 20000000) {
            $error['image_size'] = "<h5 style='color:red'>The image size must be less than 2MB</h5>";
        }
    }

    
    if (!isset($error)) {
        $target_dir = "uploads/";
        $target_file = $target_dir . basename($_FILES['image1']['name']);
        move_uploaded_file($_FILES['image1']['tmp_name'], $target_file);

        // التحقق من التكرار
        $check_sql = "SELECT * FROM products WHERE pname = :x1 AND pmodel = :x2 AND pprice = :x3 AND pram = :x4 AND pstorage = :x5 AND pcolor = :x6";
        $check_stmt = $pdo->prepare($check_sql);
        $check_stmt->execute(array('x1' => $name, 'x2' => $model, 'x3' => $cost, 'x4' => $ram, 'x5' => $storage, 'x6' => $color));

        if ($check_stmt->rowCount() == 0) {
            $insert = "INSERT INTO products (pname, pmodel, pprice, pram, pstorage, pcolor, image) VALUES (:x1, :x2, :x3, :x4, :x5, :x6, :x7)";
            $sql = $pdo->prepare($insert);

            try {
                $sql->execute(array('x1' => $name, 'x2' => $model, 'x3' => $cost, 'x4' => $ram, 'x5' => $storage, 'x6' => $color, 'x7' => $name_image));
                $message['done_insert'] = "<h3 style='color:red;'>Product added successfully</h3><br>";
                header("Location: product.php");
                exit();
            } catch (PDOException $e) {
                echo "Error: " . $e->getMessage();
            }
        } else {
            $error['duplicate'] = "<h5 style='color:red;'>Product already exists</h5>";
        }
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
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
    $(document).ready(function() {
        
        $('.toggle-active-btn').on('click', function(e) {
            e.preventDefault();
            var button = $(this);
            var url = button.attr('href');
            $.get(url, function(response) {
                if (response.status === 'success') {
                    button.text(response.button_text);
                    button.removeClass('btn-success btn-danger').addClass(response.button_class);
                } else {
                    alert('Error: ' + response.message);
                }
            });
        });
    });
    </script>
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
            <div style="color: white; padding: 15px 50px 5px 50px; float: right; font-size: 16px; display: flex;">
                <a href="../index.php" style="background-color: #e5b68a;" class="btn btn-success square-btn-adjust">Logout</a>
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
                    <li>
                        <a href="product.php"><i class="fa fa-bars"></i> cart</a>
                    </li>
                </ul>
            </div>
        </nav>
        <div id="page-wrapper">
            <div id="page-inner">
                <div class="row">
                    <div class="col-md-12">
                        <h2><i class="fa fa-bars"></i> phone</h2>
                    </div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-8">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <i class="fa fa-plus-circle"></i> Add New product
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-md-12">
                                        <form action="<?php echo $_SERVER['PHP_SELF'];?>" role="form" enctype="multipart/form-data" method="POST">
                                            <div class="form-group">
                                                <input type="hidden" name="user_id" value="">
                                                <label>The Name</label>
                                                <input type="text" placeholder="Please Enter  Name " class="form-control" name="tname" >
                                                <?php
                                                if(isset($error['nameempty'])){
                                                    echo $error['nameempty'];
                                                }
                                                elseif(isset($error['nameinteger'])){
                                                    echo $error['nameinteger'];
                                                }
                                                ?>
                                            </div>
                                            <div class="form-group">
                                                <label>Model</label>
                                                <input type="text" placeholder="Please Enter  model " class="form-control" name="model" >
                                                <?php
                                                if(isset($error['model_empty'])){
                                                    echo $error['model_empty'];
                                                }
                                                // elseif(isset($error['model_string'])){
                                                //     echo $error['model_string'];
                                                // }
                                                ?>
                                            </div>
                                            <div class="form-group">
                                                <label>Product image 1</label><br>
                                                <input type="file" class="form-control" name="image1">
                                                <?php
                                                if(isset($error['image_empty'])){
                                                    echo $error['image_empty'];
                                                }
                                            
                                                elseif(isset($error['image_type'])){
                                                    echo $error['image_type'];
                                                }
                                                elseif(isset($error['image_szie'])){
                                                    echo $error['image_size'];
                                                }
                                                ?>
                                                <label>Product image 2</label><br>
                                                <input type="file" class="form-control" name="image2">
                                                <?php
                                                if(isset($error['image_empty'])){
                                                    echo $error['image_empty'];
                                                }
                                            
                                                elseif(isset($error['image_type'])){
                                                    echo $error['image_type'];
                                                }
                                                elseif(isset($error['image_szie'])){
                                                    echo $error['image_size'];
                                                }
                                                ?>
                                                <label>Product image 3</label><br>
                                                <input type="file" class="form-control" name="image3">
                                                <?php
                                                if(isset($error['image_empty'])){
                                                    echo $error['image_empty'];
                                                }
                                            
                                                elseif(isset($error['image_type'])){
                                                    echo $error['image_type'];
                                                }
                                                elseif(isset($error['image_szie'])){
                                                    echo $error['image_size'];
                                                }
                                                ?>
                                                <!-- <label>Product image 4</label><br>
                                                <input type="file" class="form-control" name="image4"> -->
                                            </div>
                                            <div class="form-group">
                                                <label>Cost</label>
                                                <input type="text" class="form-control" placeholder="Please Enter your Cost" name="cost" >
                                                <?php
                                                if(isset($error['cost_empty'])){
                                                    echo $error['cost_empty'];
                                                }
                                                elseif(isset($error['cost_string'])){
                                                    echo $error['cost_string'];
                                                }
                                                ?>
                                                <label>RAM</label>
                                                <input type="text" class="form-control" placeholder="Please Enter SIze of RAM" name="ram" >
                                                <?php
                                                if(isset($error['ram_empty'])){
                                                    echo $error['ram_empty'];
                                                }
                                                elseif(isset($error['ram_string'])){
                                                    echo $error['ram_string'];
                                                }
                                                ?>
                                                <label>Storage</label>
                                                <input type="text" class="form-control" placeholder="Please Enter your Cost" name="storage" >
                                                <?php
                                                if(isset($error['storage_empty'])){
                                                    echo $error['storage_empty'];
                                                }
                                                elseif(isset($error['storage_string'])){
                                                    echo $error['storage_string'];
                                                }
                                                ?>
                                                 <label>color</label>
                                                <input type="text" placeholder="Please Enter  color " class="form-control" name="color" >
                                                <?php
                                                if(isset($error['colorempty'])){
                                                    echo $error['colorempty'];
                                                }
                                                elseif(isset($error['color_number'])){
                                                    echo $error['color_number'];
                                                }
                                                ?>
 
                                            </div>
                                            <div class="form-group">
                                                <label>phone Category</label>
                                                <select class="form-control" name="role_id">
                                                    <option value="1">Category 1</option>
                                                    <option value="2">Category 2</option>
                                                </select>
                                            </div>
                                            <div style="float:right;">
                                                <button type="submit" class="btn btn-primary">Add phone</button>
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
                                <i class="fa fa-bars"></i> Product
                            </div>
                            <div class="panel-body">
                                <div class="table-responsive">
                                    <table class="table table-striped table-bordered table-hover" id="dataTables-example">
                                        <thead>
                                            <tr>
                                                <th>The Name</th>
                                                <th>Model</th>
                                                <th>cost</th>
                                                <th>RAM</th>
                                                <th>Storage</th>
                                                <th>color</th>
                                                <th>Category</th>
                                                <th>image</th>
                                               
                                            </tr>
                                        </thead>
                                        
                                        
                                        <tbody>
    <?php
    $sql = "SELECT * FROM products";
    $result = $pdo->prepare($sql);
    $result->execute();

    while ($row = $result->fetch()) {
        $active_status = $row['active'] ? 'Active' : 'Inactive';
        $button_color = $row['active'] ? 'btn-success' : 'btn-danger';
        echo "<tr class='odd gradeX'>
                <td>".$row["pname"]."</td>
                <td>".$row["pmodel"]."</td>
                <td>".$row["pprice"]."</td>
                <td>".$row["pram"]."</td>
                <td>".$row["pstorage"]."</td>
                <td>".$row["pcolor"]."</td>
                <td><h4>category1</h4></td>
                <td><img src='../images/".$row["image"]."' alt='Product Image' width='100'></td>
                <td>
                    <a href='../editproduct.php?id=".$row["productID"]."' class='btn btn-success'>Edit</a>
                    <a href='../delete.php?id=".$row["productID"]."' onclick='return confirm(\"Are you sure?\")' class='btn btn-danger'>Delete</a>
 <a href='../isactive.php?id=".$row["productID"]."' class='btn $button_color'>$active_status</a>
                </td>
              </tr>";
    }
    ?>
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