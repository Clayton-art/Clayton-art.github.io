<?php
    include 'connectdb.php';

    if(isset($_POST['register'])) {
        $firstName = ucwords(trim($_POST['firstName']));
        $middleName = ucwords(trim($_POST['middleName']));
        $lastName = ucwords(trim($_POST['lastName']));
        $email = $_POST['email'];
        $age = $_POST['age'];
        $sex = $_POST['sex'];
        $dateOfBirth = $_POST['dateOfBirth'];


        $insertDataToDatabase = mysqli_query($connectionToDatabase, "INSERT INTO users (firstName, middleName, lastName, email, age, sex,
        dateOfBirth) VALUES ('$firstName', '$middleName', '$lastName', ' $email', '$age', '$sex', '$dateOfBirth')");
       
        if($insertDataToDatabase == true ){

            header("Location: view.php");
        }else{
            echo "Data was not inserted. Please check your query.";
        }
    }else{
    echo "Query Failed.";
    }
?>
