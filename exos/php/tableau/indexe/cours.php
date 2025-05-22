<?php

// Declaration des notes dans un tableau
$notes = [10, 12, 9, 12, 14];
// $notes = array (10.12.9)
echo $notes[1]; //12
//afficher les element du tableau
for ($i = 0; $i < count($notes); $i++) {
    echo $notes[$i] . '';
}

echo PHP_EOL;
//afficher les elements avec une boucle foreach
foreach ($notes as $note) {
    echo $notes . " ";
}

echo PHP_EOL;
foreach ($notes as $index => $note) {
    echo "$index : $note";
}

//Ajouter des notes
$notes[] = 15;
array_push($notes, 16);
array_push($notes, 17, 12, 8);


//Mode DEBUG
print_r($notes);
