<?php
include 'header.php';
include 'connectdb.php';

$id = $_GET['GetId'];

$retrieveSpecificUser = mysqli_query($connectionToDatabase, "SELECT * FROM users WHERE id = $id");

while ($row = mysqli_fetch_assoc($retrieveSpecificUser)) {
    $firstName = $row['firstName'];
    $middleName = $row['middleName'];
    $lastName = $row['lastName'];
    $email = $row['email'];
    $age = $row['age'];
    $sex = $row['sex'];
    $dateOfBirth = $row['dateOfBirth'];
}   
?>

<h1 style="text-align: center;">Edit User <mark><?php echo $firstName; ?></mark></h1>

<form action="update.php?GetId=<?php echo $id; ?>" method="POST" enctype="multipart/form-data">
    <label>First Name:</label>
    <input type="text" name="firstName" value="<?php echo $firstName; ?>" autocomplete="off" required><br>

    <label>Middle Name:</label>
    <input type="text" name="middleName" value="<?php echo $middleName; ?>" autocomplete="off" required><br>

    <label>Last Name:</label>
    <input type="text" name="lastName" value="<?php echo $lastName; ?>" autocomplete="off" required><br>

    <label>Email:</label>
    <input type="email" name="email" value="<?php echo $email; ?>" autocomplete="off" required><br>

    <label>Age:</label>
    <input type="number" name="age" value="<?php echo $age; ?>" autocomplete="off" required><br>

    <label>Sex:</label>
    <input type="radio" name="sex" value="Male" <?php if ($sex == 'Male') echo 'checked'; ?>> Male
    <input type="radio" name="sex" value="Female" <?php if ($sex == 'Female') echo 'checked'; ?>> Female
    <br><br>

    <label>Date of Birth:</label>
    <input type="date" name="dateOfBirth" value="<?php echo $dateOfBirth; ?>" autocomplete="off" required><br>

    <button type="submit" name="update">Update User</button>
</form>

<?php include 'footer.php'; ?>