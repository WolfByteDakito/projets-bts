<?php

$note = readline("moyenne ([0,20]) : ");

// VERSION IF IMBRIQUEE

// if ($note >= 10) {
//     if ($note == 10) {
//         echo "Tu es juste à la moyenne";
//     } else {
//         echo "Bravo tu as la moyenne";
//     }
// } else {
//     echo "Tu es en dessous de la moyenne";
// }


// VERSION IF NON IMBRIQUEE

if ($note < 10) {
    echo "Tu es en dessous de la moyenne";
} elseif ($note == 10) {
    echo "Tu es juste à la moyenne";
} else {
    echo "Bravo tu as la moyenne";
}
