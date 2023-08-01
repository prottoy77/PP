<?php
// Start session
session_start();

// Initialize $errors array
$errors = array();

// Check if the form is submitted
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $username = $_POST['username'];
    $password = $_POST['password'];

    // Validate username and password (replace this with your own validation logic)
    if (empty($username)) {
        $errors['username'] = 'Username is required.';
    }

    if (empty($password)) {
        $errors['password'] = 'Password is required.';
    }

    // Perform authentication (replace this with your own authentication logic)
    if (empty($errors) && $username === 'admin' && $password === 'password') {
        // Set session variables
        $_SESSION['username'] = $username;

        // Set cookie if remember me is checked
        if (isset($_POST['remember'])) {
            $cookie_name = 'remember_me';
            $cookie_value = $username;
            $cookie_expiry = time() + (86400 * 30); // Cookie expires in 30 days
            setcookie($cookie_name, $cookie_value, $cookie_expiry, '/');
        }

        // Redirect to the home page or any other authenticated page
        header('Location: Addproduct.php');
        exit;
    } elseif (empty($errors)) {
        $errors['login'] = 'Invalid username or password.';
    }
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Login Result</title>
</head>
<body>
    <?php if (isset($errors['login'])): ?>
        <p style="color: red;"><?php echo $errors['login']; ?></p>
    <?php endif; ?>
</body>
</html>
