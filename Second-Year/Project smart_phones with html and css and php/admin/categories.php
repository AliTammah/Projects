

<?php

include '../db.php';

// if(isset($_POST['btn-cate'])){

//     // if(isset($_POST['btn-cate'])){
//         $name=$_POST['name'];

//         $insert ="INSERT INTO 'category' ('cat_name','image') VALUES( :x1,:x2)";
//         $sql=$PDO->prepare($insert);
//         $sql->execute(array('x1'=>$name,'x2'=>$image));
//         // $pdo->exec($insert);
//         // $sql->execute();
//         try{
//             $sql->execute();

//             $message['done_insert']="<h3 style=color:red>done insert</h3> <br>";
//         }
//         catch(PDOException $e){
//             echo $e->getMessage();
//         }
// }
//     else{
//         $message['failed_insert']="<h3 style=color:red>failed insert</h3> <br>";

//     }

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $name = $_POST['name'];
    $cat_image = $_FILES['image'];

    // التحقق من أن الحقل "name" غير فارغ
    if (empty($name)) {
        $error['isempty'] = "<h5 style='color:red'>Name is required</h5>";
    }

    // التحقق من وجود الملف المرفوع
    elseif (empty($cat_image['name'])) {
        $error['imageempty'] = "<h5 style='color:red'>Image is required</h5>";
    } 
    else {
        // التحقق من نوع الملف
        $cat_image = $_FILES['image']['name'];
        $types=array("jpg","png","jpeg","gif");
        $exit=explode(".",$cat_image);
        print_r ($exit) ;
        $exit=end($exit);
        echo $exit;
        $exit=strtolower($exit);

        if (in_array($exit, $types)) {
            // التحقق من حجم الملف
            $size = $_FILES['image']['size'];
            if ($size <= 2000000) { // 2MB
                
                
                    // $move_uploaded_file($_FILES['image1']['tmp_name']);
                
                           $insert ="INSERT INTO `categories`(cat_name,image) VALUES(:x1,:x2)";
                            $sql=$pdo->prepare($insert);
                            $sql->execute(array('x1'=>$name,'x2'=>$cat_image));
                            // $pdo->exec($insert);
                            // $sql->execute();
                            try{
                                $sql->execute();
                    
                                $message['done_insert']="<h3 style=color:red>done insert</h3> <br>";
                            }
                            catch(PDOException $e){
                                echo $e->getMessage();
                            }
                
            } 
            else {
                $error['image_size'] = "<h5 style='color:red'>The image size should not exceed 2MB.</h5>";
            }
        } else {
            $error['image_type'] = "<h5 style='color:red'>Invalid image type. Only JPG, PNG, JPEG, and GIF are allowed.</h5>";
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
                <a class="navbar-brand" style="background-color: #e5b68a;" href="index.html">Control panel</a>
            </div>
            <!-- <label style="margin-right:40px;color:white;margin-left:800px;margin-top:18px;">Welcome User</label> -->
            <div style="color: white; padding: 15px 50px 5px 50px; float: right; font-size: 16px; display:flex;">
                <a href="../index.html" style="background-color: #e5b68a;" class="btn btn-success square-btn-adjust">Logout</a>
            </div>
        </nav>
        <!-- /. NAV TOP  -->
        <nav class="navbar-default navbar-side" role="navigation">
            <div class="sidebar-collapse">
                <ul class="nav" id="main-menu" style="background-color: #f6f6f6;">
                    <li>
                        <a href="index.html"><i class="fa fa-dashboard"></i> Control panel</a>
                    </li>
                    <li>
                        <a href="users.html"><i class="fa fa-users"></i> Users</a>
                    </li>
                    <li>
                        <a href="categories.html"><i class="fa fa-tasks"></i> Categories</a>
                    </li>
                    <li>
                        <a href="product.html"><i class="fa fa-bars"></i> Products</a>
                    </li>
                </ul>
            </div>
        </nav>
        <!-- /. NAV SIDE  -->
        <div id="page-wrapper">
            <div id="page-inner">
                <div class="row">
                    <div class="col-md-12">
                        <h2><i class="fa fa-tasks"></i> Categories</h2>
                    </div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-8">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <i class="fa fa-plus-circle"></i> Add New Category
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-md-12">
                                        <form action="<?php echo $_SERVER['PHP_SELF'];?>"  role="form" enctype="multipart/form-data" method="POST">
                                            <div class="form-group">
                                                <input type="hidden" name="C_id" value="">
                                                <label>Name</label>
                                                <input type="text" placeholder="Please Enter your Name" class="form-control" name="name" >
                                                <?php
                                                if(isset($error['isempty'])){
                                                    echo $error['isempty'];
                                                }

                                                ?>
                                            </div>
                                            <div class="form-group">
                                                <label>Category Image</label><br>
                                                <!-- <img src="../../../images/default.jpg" alt="Category Image" style="border: none; width: 100px; border-radius: 50px; height: 100px; object-fit: fill;"> -->
                                                <input type="file" class="form-control" name="image">
                                                <?php
                                                if(isset($error['imageempty'])){
                                                    echo $error['imageempty'];
                                                }
                                                elseif(isset($error['image_size'])){
                                                    echo $error['image_size'];
                                                }
                                                elseif(isset($error['image_type'])){
                                                    echo $error['image_type'];
                                                }
                                                ?>
                                            </div>
                                            <div style="float:right;">
                                                <button name="btn-cate" type="submit" class="btn btn-primary">Add Category</button>
                                                <!-- 
                                                // < ?php
                                                // if(!empty($message['done_insert'])){
                                                //     echo $message['done_insert']."<br>";
                                                // }
                                                // else{
                                                //     // echo $message['failed_insert']."<br>";
                                                //     echo "failed";

                                                // }


                                                // ?>
                                                 -->
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
                                <i class="fa fa-tasks"></i> Categories
                            </div>
                            <div class="panel-body">
                                <div class="table-responsive">
                                    <table class="table table-striped table-bordered table-hover" id="dataTables-example">
                                        <thead>
                                            <tr>
                                                <th>Number</th>
                                                <th>Name</th>
                                                <th>Image</th>
                                                <th>Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>1</td>
                                                <td>Example Category</td>
                                                <td><img src="../img/default.jpg" align="center" style="border: none; width: 100px; border-radius: 50px; height: 60px; object-fit: fill;"></td>
                                                <td>
                                                    <a href="edit_category.html" class='btn btn-success'>Edit</a>
                                                    <a href="delete_category.html" class='btn btn-danger'>Delete</a>
                                                    <a href="activate_category.html" class='btn btn-warning'>Activate</a>
                                                </td>
                                            </tr>
                                            <!-- More rows can be added here -->
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /. ROW  -->
                </div>
                <!-- /. PAGE INNER  -->
            </div>
            <!-- /. PAGE WRAPPER  -->
        </div>
    </div>
    <!-- /. WRAPPER  -->
    <!-- SCRIPTS -AT THE BOTOM TO REDUCE THE LOAD TIME-->
    <!-- JQUERY SCRIPTS -->
    <script src="assets/js/jquery-1.10.2.js"></script>
    <!-- BOOTSTRAP SCRIPTS -->
    <script src="assets/js/bootstrap.min.js"></script>
    <!-- METISMENU SCRIPTS -->
    <script src="assets/js/jquery.metisMenu.js"></script>
    <!-- MORRIS CHART SCRIPTS -->
    <script src="assets/js/morris/raphael-2.1.0.min.js"></script>
    <script src="assets/js/morris/morris.js"></script>
    <!-- CUSTOM SCRIPTS -->
    <script src="assets/js/custom.js"></script>
</body>

</html>