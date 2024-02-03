<?php  
    $con=mysqli_connect("localhost","root","","cimage");
    if($_SERVER['REQUEST_METHOD']==="POST")
    {

        if(!empty($_REQUEST['uname'] && !empty($_REQUEST['email'] && !empty($_REQUEST['password']))))
        {
            $name=trim($_REQUEST['uname']);
            $email=$_REQUEST['email'];
            $password=($_REQUEST['password']);
            $query1="INSERT into sign_up(username,email,password) values ('$name','$email','$password')";
            $rs=mysqli_query($con,$query1);
            if($rs){
            echo "Record added successfully.";
            }
            else{
                echo "Failed to add record";
            }
        }
    }
    if($_SERVER['REQUEST_METHOD']==="POST")
    {
        if(!empty(!empty($_REQUEST['email1'] && !empty($_REQUEST['password1']))))
        {
            $email1=trim($_REQUEST['email1']);
            $password1=($_REQUEST['password1']);
            // $query="INSERT into log_in(username	,password) values ('$email1','$password1')";
            $query="SELECT * FROM sign_up where email='$email1' and password='$password1' " ;

            $rs=mysqli_query($con,$query);
            if($rs){
                $row = mysqli_num_rows($rs);
                if($row==1)
                {
                    header("location: success.html");
                }
                else{
                    echo "Invalid username & password";
                }
            // echo "Record added successfully.";
            }
            else{
                echo "Failed to add record";
            } 
        }
    }
    ?>




<!DOCTYPE html>
 <html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.css">
    <link rel="stylesheet" href="./styles.css">
    <title>Sign Up || Log In</title>

    <style>
        @import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@700&display=swap'); 
*{
    box-sizing: border-box;
    margin: 0;
    padding: 0;

}
body {
    display: grid;
    place-items: center;
    font-family:'Montserrat',sans-serif  ;
    height:100vh;
}
h1{
    font-size: bold;
    margin: 0;
}
p {
    font-size: 1em;
    font-weight: 100;
    line-height: 1.3em;
    letter-spacing: .1em;
    margin:20px 0; 
}  
span{
    font-size:12px;
}

button{
    border-radius: 2em;
    border: 1px solid #FFF;
    background: #21a9d3;
    color: #FFFFFF;
    font-size: 12px;
    font-weight: bold;
    padding: 1em 5em;
    text-transform: uppercase;
    cursor: pointer;
    transition:transform 80ms ease-in;
} 

.sign_up{
    background-color: #168aad;
    color: white;
}
button:active{
    transform: scale(0.95);
}

button:focus{
    outline : none;
}

form{
    background-color: #FFFFFF;
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
    padding: 0 50px;
    height: 100%;
    text-align: center;
}

input{
    background-color: #eeee;
    border: none;
    font-size: 16px;
    padding: 10px 12px;
    margin: 8px 0;
    width: 100%;

}
a {
   color: #333; 
   font-size: 14px;
   text-decoration: none;
   margin: 15px 0;
}

button.ghost {
    background-color: transparent;
    border-color:#FFFFFF ;
}
.container{
    background-color: #fff;
    border-radius: 2em;
    box-shadow: 0 14px 28px rgb(0,0,0.25),0 10px 10px rgba(0,0,0,0.22);
    position: relative;
    overflow: hidden;
    width: 650px;
    max-width: 100%;
    min-height: 550px;
}
.form-container{
    position: absolute;
    top: 0;
    height: 100%;
    transition: all 0.6s ease-in-out;
}
.sign-in-container{
    left: 0;
    width: 50%;
    z-index: 2;
}
.sign-up-container{
    left: 0;
    width: 50%;
    opacity: 0;
    z-index: 1;
}

.container.right-panel-active .sign-in-container {
    transform: translateX(100%);
}

.container.right-panel-active .sign-up-container {
    transform: translateX(100%);
    opacity: 1;
    z-index: 5;
    animation: show 0.6s;
}

@keyframes show {
    0%,49.99% {
        opacity: 0;
        z-index: 1;
    }
    50%,100% {
        opacity: 1;
        z-index: 5;
    }
}

.container.container.right-panel-active .overlay-container {
    transform: translateX(-100%);
}

.container.right-panel-active .overlay {
    transform: translateX(50%);
}

.container.right-panel-active .overlay-left {
    transform: translateX(0);

}

.container.right-panel-active .overlay-right{
    transform: translateX(20%);
}

.overlay-container{
    position: absolute;
    top: 0;
    left: 50%;
    width: 50%;
    height: 100%;
    overflow: hidden;
    transition: transform 0.6s ease-in-out;
    z-index: 100;
}
.overlay{
    background: #168aad;
    background: -webkit-linear-gradient(20deg,#34a0a4,#168aad);
    background:linear-gradient(0deg,#34a0a4,#168aad);
    background-repeat:no-repeat;
    background-size: cover;
    background-position: 0 0;
    color: #FFFFFF;
    position: relative;
    left: -100%;
    height: 100%;
    width: 200%;
    transform: translateX(0);
    transition: 0.6s ease-in-out;
}
.overlay-panel{
    position: absolute;
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
    padding: 0 40px;
    text-align: center;
    top: 0;
    height: 100%;
    width: 50%;
    transform: translateX(0);
    transition: transform 0.6s ease-in-out;

}
.overlay-left{
    transform: translateX(-20%);

}
.overlay-right {
    right:0;
    transform:translateX(0);
}
.social-container{
    margin: 20px 0;
}
.social-container a{
    border: 1px solid #DDDDDD;
    border-radius: 50%;
    display: inline-flex;
    justify-content: center;
    align-items: center;
    margin: 0 5px;
    height: 40px;
    width: 40px;
}
    </style>

    <script>
const signUpButton = document.getElementById('signUp')
const signInButton = document.getElementById('signIn')
const container = document.getElementById('container')


signUpButton.addEventListener('click',() =>{
    container.classList.add("right-panel-active")
})

signInButton.addEventListener('click', () => {
    container.classList.remove("right-panel-active")
})
    </script>

</head>
<body>

    <div class="container" id="container">
        <!-- header -->
        <div class="form-container sign-up-container">
            <form action="#" method="POST">
                <h1>Create An Account</h1>
                <div class="social-container">
                    <a href="#">
                        <i class="fab fa-facebook"></i>
                    </a>
                    <a href="#">
                        <i class="fab fa-google"></i>
                    </a>
                    <a href="#">
                        <i class="fab fa-github"></i>
                    </a>
                </div>
                <span> use your email for registration </span>
                <input type="text" placeholder="Name" name="uname">
                <input type="email" placeholder="Email" name="email">
                <input type="password" placeholder="Password" name="password"><br>
                <!-- <input type="submit"name="sub" value="Sign Up"> -->
                
                <button type="submit" >Sign Up</button>
                <!-- <button>Sign Up</button> -->
            </form>
        </div>
        <div class="form-container sign-in-container"> 
            <form action="#" method="post">
                <h1>Log In </h1>
                <div class="social-container">
                    <a href="#">
                        <i class="fab fa-facebook"></i>
                    </a>
                    <a href="#">
                        <i class="fab fa-google"></i>
                    </a>
                    <a href="#">
                        <i class="fab fa-github"></i> 
                    </a>
                </div>
                <span>Login to your account</span>
                <input type="email" placeholder="Email" name="email1">
                <input type="password" placeholder="Password" name="password1"><br>
                <a href="#">Forget your password</a>

                <!-- <button class="log_in">
                    <input type="submit"name="sub1" value="Log In">
                </button> -->
                <button type="submit" >Log In</button>


                <!-- <button>Sign In</button> -->
            </form>
        </div>
        <div class="overlay-container">
            <div class="overlay">
                <div class="overlay-panel overlay-left">
                    <h1>Have Already Account</h1>
                    <p>to keep connect with us please login with your account here!</p>
                    <button class="ghost" id="signIn">Log In</button>
                </div>
                <div class="overlay-panel overlay-right"> 
                    <h1>Create Your Account</h1>
                    <p>Enter your personal detail and start journey with us.</p> 
                    <button class="ghost" id="signUp">Sign Up</button>
                </div>
            </div> 
        </div>

    </div>
    <script src="./index.js"></script>
    </body>
    </html>