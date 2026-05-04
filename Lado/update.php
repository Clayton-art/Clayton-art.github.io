<?php
include 'connectdb.php';

if (isset($_POST['update'])) {
    $id = $_GET['GetId'];
    $firstName = ucwords(trim($_POST['firstName']));
    $middleName = ucwords(trim($_POST['middleName']));
    $lastName = ucwords(trim($_POST['lastName']));
    $email = $_POST['email'];
    $age = $_POST['age'];
    $sex = $_POST['sex'];
    $dateOfBirth = $_POST['dateOfBirth'];

    $editSpecificUser = mysqli_query($connectionToDatabase, 
        "UPDATE users 
        SET firstName = '$firstName', 
            middleName = '$middleName', 
            lastName = '$lastName', 
            email = '$email', 
            age = '$age', 
            sex = '$sex',
            dateOfBirth = '$dateOfBirth' 
        WHERE id = '$id'");

    if ($editSpecificUser) {
        header("Location: view.php");
        exit();
    } else {
        echo "Data was not inserted. Please check your query. " . mysqli_error($connectionToDatabase);
    }
} else {
    echo "Query failed.";
}
?>
