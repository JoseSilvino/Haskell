pertence :: Integer ->[Integer]-> Bool
pertence x [] = False
pertence x (a:as)
      |(x == a) = True
      |otherwise = pertence x as
eGrafo :: [Integer] -> [(Integer,Integer)] -> Bool
eGrafo [] _ = False
eGrafo v [] = True
eGrafo v ((o,d):as) = o `pertence` v && d `pertence` v && eGrafo v as

grau:: Integer->[(Integer,Integer)]->Integer
grau v [] = 0
grau v ((x,y):as) 
                 | v == x = if(v==y) then 2 + grau v as else 1 + grau v as
                 | v == y && not(v==x) = 1 + grau v as
                 | otherwise = grau v as