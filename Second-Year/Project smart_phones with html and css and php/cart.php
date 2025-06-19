<?php

include 'include/header.php';
// include 'include/footer.php';


?>
    <!-------------------- cart items details ----------->
    <div class="small-container cart-page">
        <table>
            <tr>
                <th>Product</th>
                <th>number</th>
                <th>Subtotal</th>
            </tr>
            <tr>
                <td>
                    <div class="cart-info">
                        <img src="images/product-4.jpg">
                        <div>
                            <p>Sample Product Name</p>
                            <small>Price: $10.00</small>
                            <br>
                            <a href="#">Remove</a>
                        </div>
                    </div>
                </td>
                <td>$10.00</td>
            </tr>
            <tr>
                <td>
                    <div class="cart-info">
                        <img src="images/product-2.jpg">
                        <div>
                            <p>Sample Product Name</p>
                            <small>Price: $10.00</small>
                            <br>
                            <a href="#">Remove</a>
                        </div>
                    </div>
                </td>
                <td>$10.00</td>
            </tr>
            <tr>
                <td>
                    <div class="cart-info">
                        <img src="images/product-6.jpg">
                        <div>
                            <p>Sample Product Name</p>
                            <small>Price: $10.00</small>
                            <br>
                            <a href="#">Remove</a>
                        </div>
                    </div>
                </td>
                <td>$10.00</td>
            </tr>
            <!-- Add more product rows as needed -->
        </table>
        <div class="total-price">
            <table>
                <tr>
                    <td>Subtotal</td>
                    <td>$30.00</td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <a class="btn" href="#">PAY</a>
                    </td>
                </tr>
            </table>
        </div>
    </div>

    <!-------------------- Footer ----------------------->
    <?php

// include 'include/header.php';
include 'include/footer.php';

?>
</body>

</html>