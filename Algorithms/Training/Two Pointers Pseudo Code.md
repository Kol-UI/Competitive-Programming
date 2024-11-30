Two Pointers Pseudo Code :

1) Vérifier si le tableau est vide ou nul.
   - Si oui, retourner une valeur par défaut (exemple : false, null, etc.).

2) Initialiser deux pointeurs :
   - left = 0 (début du tableau)
   - right = array.Length - 1 (fin du tableau)

3) Tant que left < right :
   - Vérifier une condition spécifique sur array[left] et array[right].
     - Si la condition est satisfaite, effectuer une action (exemple : return, stocker une valeur, etc.).
   
4) Mettre à jour les pointeurs :
   - Incrémenter left, décrémenter right ou effectuer une autre mise à jour spécifique.

5) Si la boucle se termine sans résultat, retourner une valeur par défaut.





Trouver si deux nombres dans un tableau trié ont une somme donnée (TargetSum):

1) Si array est nul ou array.Length < 2, retourner false.

2) Initialiser left = 0 et right = array.Length - 1.

3) Tant que left < right :
   - Calculer sum = array[left] + array[right].
   - Si sum == target, retourner true.
   - Si sum < target, incrémenter left.
   - Si sum > target, décrémenter right.

4) Retourner false (aucune paire trouvée).




Trouver dans un tableau trié les deux nombres dont la somme est la plus proche d'une cible donnée (ClosestTargetSum) :

1) Si array est nul ou array.Length < 2, retourner une paire vide (ou null).

2) Initialiser :
   - left = 0 (début du tableau)
   - right = array.Length - 1 (fin du tableau)
   - closestSum = ∞ (ou une grande valeur initiale)
   - closestPair = null (ou une structure vide pour stocker la paire)

3) Tant que left < right :
   - Calculer sum = array[left] + array[right].
   - Si |sum - target| < |closestSum - target| :
       - Mettre à jour closestSum avec sum.
       - Mettre à jour closestPair avec (array[left], array[right]).
   - Si sum < target :
       - Incrémenter left (pour augmenter sum).
   - Sinon si sum > target :
       - Décrémenter right (pour réduire sum).
   - Sinon (sum == target) :
       - Retourner directement (array[left], array[right]) car c'est une correspondance exacte.

4) Retourner closestPair après la boucle.


Enlever les duplicatas d'une array triée (RemoveDuplicates) :
1) Validation des entrées :
   - Si le tableau nums est null ou a moins de 2 éléments, il n'y a pas de doublons à retirer. La fonction retourne 1.

2) Initialisation :
   - left est le pointeur d'écriture où l'on stockera les prochains éléments uniques.
   - On commence à 1, car le premier élément est toujours unique.

3) Boucle principale :
   - On utilise right pour parcourir chaque élément du tableau (nums[right]).
   - Pour chaque élément, on vérifie si nums[right] est différent du dernier élément unique stocké (nums[left - 1]).
      - Si oui : C'est un nouvel élément unique.
         - On le place à nums[left].
         - On incrémente left.
      - Si non : C'est un doublon, donc on l'ignore.

4) À la fin de la boucle, left contient le nombre d'éléments uniques.




Vérification de palindrome (IsPalindrome) :

1) Si input est null ou vide, retourner true (une chaîne vide ou nulle est considérée comme un palindrome).

2) Initialiser deux pointeurs :
   - left = 0 (début de la chaîne).
   - right = input.Length - 1 (fin de la chaîne).

3) Tant que left < right :
   a) Ignorer les caractères non alphanumériques en déplaçant les pointeurs :
      - Tant que left < right ET input[left] n'est pas une lettre ou un chiffre, incrémenter left.
      - Tant que left < right ET input[right] n'est pas une lettre ou un chiffre, décrémenter right.
   
   b) Comparer les caractères pointés par left et right après les avoir mis en minuscule :
      - Si input[left] (en minuscule) est différent de input[right] (en minuscule), retourner false (ce n'est pas un palindrome).

   c) Déplacer les pointeurs :
      - Incrémenter left.
      - Décrémenter right.

4) Si la boucle se termine sans trouver de différence, retourner true (la chaîne est un palindrome).





Déplacer tous les zéros à la fin de l'array tout en gardant l'order des non-zéros (MoveZeroes) :

1) Initialiser deux pointeurs :
   - left = 0 (position où le prochain élément non-zéro doit être placé).

2) Boucler sur le tableau avec right :
   a) Si nums[right] != 0 :
      - Échanger nums[left] avec nums[right].
      - Incrémenter left (car un élément non-zéro a été placé).

3) Une fois la boucle terminée, tous les zéros seront déplacés à la fin du tableau.

4) Retourner ou terminer sans créer une nouvelle copie du tableau (modification en place).




Inverser une array avec la technique Two Pointers (ReverseArray) :

1) Initialiser deux pointeurs :
   - left = 0 (début du tableau).
   - right = array.Length - 1 (fin du tableau).

2) Boucler tant que left < right :
   a) Échanger array[left] avec array[right].
   b) Incrémenter left pour avancer vers le centre.
   c) Décrémenter right pour avancer vers le centre.

3) Une fois la boucle terminée, le tableau est inversé.

4) Retourner ou terminer (le tableau est modifié en place).




Vérifier si un tableau trié contient une paire dont le produit est égal à une cible donnée (ContainsProductPair) :

1) Vérifier si le tableau est vide ou nul.
   - Si oui, retourner false.

2) Initialiser deux pointeurs :
   - left = 0 (début du tableau)
   - right = array.Length - 1 (fin du tableau)

3) Tant que left < right :
   a) Calculer le produit : product = array[left] * array[right].
   b) Vérifier la condition :
      - Si product == target, retourner true (la paire existe).
      - Si product < target, incrémenter left (pour augmenter le produit).
      - Si product > target, décrémenter right (pour réduire le produit).

4) Si la boucle se termine sans trouver de paire, retourner false.




Trouver la plus longue sous-séquence sans répétition dans une chaîne de caractères (LongestSubstringWithoutRepeating)

1) Si la chaîne est vide ou nulle, retourner 0.

2) Initialiser :
   - left = 0 (pointeur gauche)
   - right = 0 (pointeur droit)
   - seenCharacters = dictionnaire vide (pour stocker chaque caractère et sa dernière position dans la chaîne)
   - maxLength = 0 (longueur maximale de la sous-séquence sans répétition)

3) Tant que right < longueur de la chaîne :
   Si le caractère input[right] est dans seenCharacters et que seenCharacters[input[right]] >= left :
      Déplacer le pointeur gauche (left) juste après la dernière position du caractère dans seenCharacters
   Mettre à jour ou ajouter la position actuelle du caractère input[right] dans seenCharacters
   Calculer la longueur actuelle de la sous-séquence currentLength = right - left + 1
   Mettre à jour maxLength si currentLength > maxLength.

4) Incrémenter le pointeur droit (right).

5) Retourner maxLength.




Fusionner deux tableaux triés (MergeSortedArrays) :
1) Initialiser les pointeurs :
   - i = 0 (pointe sur le premier élément de array1).
   - j = 0 (pointe sur le premier élément de array2).

2) Initialiser une liste vide mergedArray pour stocker les éléments fusionnés.

3) Boucler tant que i < array1.Length et j < array2.Length :
   a) Si array1[i] <= array2[j], ajouter array1[i] à mergedArray et incrémenter i.
   b) Sinon, ajouter array2[j] à mergedArray et incrémenter j.

4) Une fois la boucle terminée :
   a) Ajouter tous les éléments restants de array1 (s'il en reste) à mergedArray.
   b) Ajouter tous les éléments restants de array2 (s'il en reste) à mergedArray.

5) Retourner mergedArray.



Étant donné un entier non négatif c, déterminer s'il existe deux entiers non négatifs a et b tels que a^2 + b^2 = c. (SumOfSquareNumbers) :

1) Vérifier si c est négatif :
   - Si oui, retourner false (car les carrés de deux nombres ne peuvent pas être négatifs).

2) Initialiser deux pointeurs :
   - left = 0 (correspond à a).
   - right = sqrt(c) (correspond à b, car b^2 ne peut pas être plus grand que c).

3) Tant que left <= right :
   a) Calculer la somme des carrés : sum = left^2 + right^2.
   b) Vérifier la condition :
      - Si sum == c, retourner true (la paire (a, b) existe).
      - Si sum < c, incrémenter left (pour augmenter la somme).
      - Si sum > c, décrémenter right (pour réduire la somme).

4) Si la boucle se termine sans trouver une paire, retourner false.



Étant donné une chaîne de caractères s et un caractère c, retourner un tableau d'entiers où chaque élément indique la distance minimale entre cet index et une occurrence de c dans la chaîne (ShortestDistanceToChar) :

1) Initialiser un tableau result de la même taille que s avec des valeurs infinies (ou un grand entier).

2) Parcours gauche-droite :
   a) Initialiser un pointeur left = -1 (signifiant aucune occurrence de c rencontrée).
   b) Parcourir chaque caractère de s :
      - Si s[i] == c, mettre left = i.
      - Mettre à jour result[i] avec la distance au dernier c rencontré (i - left), ou une grande valeur si aucun c n'a été rencontré.

3) Parcours droite-gauche :
   a) Initialiser un pointeur right = -1 (signifiant aucune occurrence de c rencontrée).
   b) Parcourir chaque caractère de s à l’envers :
      - Si s[i] == c, mettre right = i.
      - Mettre à jour result[i] avec la distance minimale entre le dernier c rencontré à gauche (result[i]) et le prochain c rencontré à droite (right - i).

4) Retourner result.




Trouver des doublons adjacents dans une liste triée (ContainsAdjacentDuplicates) :

1) Vérifier si le tableau est vide ou a moins de deux éléments :
   - Si oui, retourner false (pas de doublons possibles).

2) Initialiser deux pointeurs :
   - left = 0 (pointeur sur le premier élément).
   - right = 1 (pointeur sur l'élément suivant).

3) Tant que right < array.Length :
   - Comparer array[left] et array[right].
     a) Si array[left] == array[right], retourner true (doublon trouvé).
     b) Sinon, incrémenter les deux pointeurs :
        - left++
        - right++

4) Si la boucle se termine sans doublon, retourner false.







Done :
- Trouver si deux nombres dans un tableau trié ont une somme donnée (TargetSum)
- Trouver dans un tableau trié les deux nombres dont la somme est la plus proche d'une cible donnée (ClosestTargetSum)
- Vérification de palindrome (IsPalindrome)
- Déplacer tous les zéros à la fin de l'array tout en gardant l'order des non-zéros (MoveZeroes)
- Inverser une array avec la technique Two Pointers (ReverseArray) 
- Vérifier si un tableau trié contient une paire dont le produit est égal à une cible donnée (ContainsProductPair)
- Trouver la plus longue sous-séquence sans répétition dans une chaîne de caractères (LongestSubstringWithoutRepeating)
- Fusionner deux tableaux triés (MergeSortedArrays)
- Étant donné un entier non négatif c, déterminer s'il existe deux entiers non négatifs a et b tels que a^2 + b^2 = c. (SumOfSquareNumbers)
- Étant donné une chaîne de caractères s et un caractère c, retourner un tableau d'entiers où chaque élément indique la distance minimale entre cet index et une occurrence de c dans la chaîne (ShortestDistanceToChar)
- Trouver des doublons adjacents dans une liste triée (ContainsAdjacentDuplicates)


