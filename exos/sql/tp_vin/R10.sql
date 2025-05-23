SELECT B.numbuv, B.nombuv
FROM BUVEUR B
WHERE NOT EXISTS (
    SELECT 1
    FROM ABU A
    WHERE A.numbuv = B.numbuv
      AND A.numvin = 2
);
