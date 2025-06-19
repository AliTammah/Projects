
<?php
// include	'../include/header.php';

include '../db.php';
session_start();
// if($_SERVER['REQUEST_METHOD'=='POST']){

if(!empty($_POST['btn_login'])){

	$username=$_POST['username'];
	$password=$_POST['password'];

	$select =$pdo->prepare("select *from users where name='$username' and password='$password'" );

	$select->execute();
	$row=$select->fetch(PDO::FETCH_ASSOC);

	if($row['name']==$username and $row['password']==$password ){
		// $_SESSION['admin_id']=$row['admin_id'];
		// $_SESSION['name']=$row['username'];
		// $_SESSION['password']=$row['password'];
		// $_SESSION['email']=$row['email'];
		// $_SESSION['phone']=$row['phone'];
		$message['success']="<h5 style=color:red>success login</h5>";

	}

	else{
		$error['failed']="<h5 style=color:red>username or passsword is wrong</h5>";
	}


}
// else{
// 	$empty['empty']="<h5 style=color:red>username and password is requierd</h5>";
// }







?>
<!DOCTYPE html>
<html lang="en" >
<head>
  <meta charset="UTF-8">
  <title>sign in</title>
  <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.2.0/css/all.css'>
<link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.2.0/css/fontawesome.css'><link rel="stylesheet" href="./style.css">

</head>
<body>
<!-- partial:index.partial.html -->
<div class="container">
	<div class="screen">
		<div class="screen__content">
			<form class="login" action="<?php echo $_SERVER['PHP_SELF'];?> " method="POST">
				<div class="login__field">
					<i class="login__icon fas fa-user"></i>
					<input  type="text" class="login__input" placeholder="User name / Email" name="username" >
				</div>
				<div class="login__field">
					<i class="login__icon fas fa-lock"></i>
					<input type="password" class="login__input" placeholder="Password" name="password">
				</div>
				<button type="submit" class="button login__submit" name="btn_login" message="POST">
					<span class="button__text">Log In Now</span>
					<i class="button__icon fas fa-chevron-right"></i>
				</button>			
				<?php
				if(!empty($message['success'])){
					echo $message['success'];
				}
				elseif(!empty($error['failed'])){
					echo $error['failed'];
				}
				// else{
					
				// 	// echo $empty['empty'];
				// 	echo "<h5 style=color:red>username and password is requierd</h5>";
				// }

				
				?>
			</form>
			<div class="social-login">
				<h3>log in via</h3>
				<div class="social-icons">
					<a href="#" class="social-login__icon fab fa-instagram"></a>
					<a href="#" class="social-login__icon fab fa-facebook"></a>
					<a href="#" class="social-login__icon fab fa-twitter"></a>
				</div>
				<a href="../account.php" style="text-decoration:none ">create account??</a>
			</div>
		</div>
		<div class="screen__background">
			<span class="screen__background__shape screen__background__shape4"></span>
			<span class="screen__background__shape screen__background__shape3"></span>		
			<span class="screen__background__shape screen__background__shape2"></span>
			<span class="screen__background__shape screen__background__shape1"></span>
		</div>	
		<!-- <div></div>	 -->
	</div>
</div>
<!-- partial -->
<?php
include	'../include/footer.php';
?>
</body>
</html>
