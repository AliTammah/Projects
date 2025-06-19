<?php

include 'include/header.php';
// include 'include/footer.php';
include 'db.php';
//session_start();

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    // Database connection
   
    // Check connection


    // Retrieve product data
    $name = $_POST['product_name'];
    $price = $_POST['product_price'];
    // $model = $_POST['product_model'];

    // Insert into database
    $stmt = $pdo->prepare("INSERT INTO cart(productname, price) VALUES (:x1, :x2)");
    try{
    $stmt->execute( array('x1' => $name,'x2'=> $price));
    echo "Product added to cart successfully!";
    }
   catch(PDOException $e) {
    $error = "Error: " . $e->getMessage();
}

    // $stmt->close();
    // $pdo->close();
}
?>
    <!--------------------  single product details ---------------->
    <div class="small-container single-product">
        <div class="row">
            <div class="col-2">
                <img src="images/s25.webp" width="100%" id="productImg">
                <div class="small-img-row">
                    <div class="small-img-col">
                        <img src="images/ip1.jpg" width="100%" class="small-img">
                    </div>
                    <div class="small-img-col">
                        <img src="images/ip2.jpg" width="100%" class="small-img">
                    </div>
                    <div class="small-img-col">
                        <img src="images/ip3.jpg" width="100%" class="small-img">
                    </div>
                    <div class="small-img-col">
                        <img src="images/sam1.jpg" width="100%" class="small-img">
                    </div>
                </div>
            </div>
            <div class="col-2">
            <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="POST">
    <!-- استخدام حقول مخفية لتخزين القيم -->
    <input type="hidden" name="product_name" value="iPhone 16 Pro">
    <input type="hidden" name="product_price" value=1000.00>
    
    <!-- عرض القيم للمستخدم (اختياري) -->
    <h1>iPhone 16 Pro</h1>
    <h4>$1000.00</h4>
    
    <!-- زر الإرسال -->
    <button type="submit" class="btn">Add To Cart</button>
</form>
            </div>
        </div>
    </div>

    <!-------------------- title ------------------------>
    <div class="small-container">
        <div class="row row-2">
            <h2>Related phones</h2>
            <p>View More</p>
        </div>
    </div>

    <!-------------------- products --------------------->
    <div class="small-container">
        <div class="row">
            <div class="col-4">
                <img src="images/sam2.jpg">
                <h4>s21</h4>
                <p>$500.00</p>
            </div>
            <div class="col-4">
                <img src="images/LG2.jpg">
                <h4>M40</h4>
                <p>$300.00</p>
            </div>
            <div class="col-4">
                <img src="images/LG3.jpg">
                <h4>s10</h4>
                <p>$600.00</p>
            </div>
            <div class="col-4">
                <img src="images/LT2.jpg">
                <h4>LT</h4>
                <p>$50.00</p>
            </div>
        </div>
    </div>

    <div class="footer">
        <div class="container">
            <div class="row">
                <div class="footer-col-1">
                    <h3>Download Our App</h3>
                    <p>Download App for Android and iOS mobile phone.</p>
                    <div class="app-logo">
                        <img src="images/play-store.png">
                        <img src="images/app-store.png">
                    </div>
                </div>
                <div class="footer-col-2">
                    <img src="images/logo-white.png">
                    <p>Our Purpose Is To Sustainably Make the Pleasure and Benefits of Sports Accessible to the Many.</p>
                </div>
                <div class="footer-col-3">
                    <h3>Useful Links</h3>
                    <ul>
                        <li>Coupons</li>
                        <li>Blog</li>
                        <li>Return Policy</li>
                        <li>Join Affiliate</li>
                    </ul>
                </div>
                <div class="footer-col-4">
                    <h3>Follow us</h3>
                    <ul>
                        <li>Facebook</li>
                        <li>Twitter</li>
                        <li>Instagram</li>
                        <li>YouTube</li>
                    </ul>
                </div>
            </div>
            <hr>
            <p class="copy">Copyright 2024 - Hour'a Al-Zien</p>
        </div>
    </div>

    <script>
        var MenuItems = document.getElementById("MenuItems");
        MenuItems.style.maxHeight = "0px";
        function menutoggle() {
            if (MenuItems.style.maxHeight == "0px") {
                MenuItems.style.maxHeight = "200px";
            } else {
                MenuItems.style.maxHeight = "0px";
            }
        }

        var productImg = document.getElementById("productImg");
        var smallImg = document.getElementsByClassName("small-img");
        smallImg[0].onclick = function () {
            productImg.src = smallImg[0].src;
        }
        smallImg[1].onclick = function () {
            productImg.src = smallImg[1].src;
        }
        smallImg[2].onclick = function () {
            productImg.src = smallImg[2].src;
        }
        smallImg[3].onclick = function () {
            productImg.src = smallImg[3].src;
        }
    </script>
</body>

</html>