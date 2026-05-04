<?php include 'header.php'; ?>
    <h1>Register Here!</h1>
    <form action="insert.php" method="POST" enctype="multipart/form-data">
        <label for="firstName">First Name: </label>
        <input type="text" name="firstName" autocomplete="off" required><br>


        <label for="middleName">Middle Name: </label>
        <input type="text" name="middleName" autocomplete="off" required><br>


        <label for="lastName">Last Name: </label>
        <input type="text" name="lastName" autocomplete="off" required><br>


        <label for="email">Email: </label>
        <input type="text" name="email" autocomplete="off" required><br>


        <label for="age">Age: </label>
        <input type="number" name="age" autocomplete="off" required><br>


        <label for="sex">Sex: </label>
        <input type="radio" name="sex" value="Male"><span>Male</span>
        <input type="radio" name="sex" value="Female"><span>Female</span><br>


        <label for="date of birth">Date of Birth:</label>
        <input type="datetime-local" name="dateOfBirth" autocomplete="off" required><br>


        <button type="submit" name="register" class="button">Register User</button>


    </form>


<?php include 'footer.php'; ?>
