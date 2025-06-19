<?php

include 'include/header.php';
// include 'include/footer.php';

?>
    <!-------------------- account page ----------->
    <div class="account-page">
        <div class="container">
            <div class="row">
                <div class="col-2">
                    <img src="images/ph6.png" width="100%">
                </div>
                <div class="col-2">
                    <div class="form-container" style="height: 500px; overflow: auto;">
                        <div class="form-btn">
                            <span>Profile Account</span>
                        </div>
                        <form action="" method="POST">
                            <input type="text" placeholder="Name" name="name" required>
                            <br>
                            <input type="text" placeholder="Email" name="email" required>
                            <br>
                            <input type="tel" placeholder="Phone" name="phone" required>
                            <br>
                            <input type="text" placeholder="Address" name="address" required>
                            <br>
                            <input type="password" placeholder="Password" name="pass" required>
                            <br>
                            <input type="submit" class="btn" name="update" value="Update Account">
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-------------------- Footer ----------------------->
    <?php

// include 'include/header.php';
include 'include/footer.php';

?>
</body>

</html>