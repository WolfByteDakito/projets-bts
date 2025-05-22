<?php

$email = readline("Saisir un email : ");
if (filter_var($email, FILTER_VALIDATE_EMAIL)) {
    echo "{$email}: A valid email";
} else {
    echo "{$email}: Not a valid email";
}
