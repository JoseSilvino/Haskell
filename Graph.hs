pertence :: (Eq a) =>a ->[a]-> Bool
pertence x [] = False
pertence x (a:as)
      |(x == a) = True
      |otherwise = pertence x as
eGrafo :: (Eq a)=>[a] -> [(a,a)] -> Bool
eGrafo [] _ = False
eGrafo v [] = True
eGrafo v ((o,d):as) = o `pertence` v && d `pertence` v && eGrafo v as

grau:: (Eq a) =>a->[(a,a)]->Integer
grau v [] = 0
grau v ((x,y):as) 
                 | v == x = if(v==y) then 2 + grau v as else 1 + grau v as
                 | v == y  = 1 + grau v as
                 | otherwise = grau v as

grauEmissao :: (Eq a) =>a -> [(a,a)] ->Integer
grauEmissao v [] = 0
grauEmissao v ((x,y):as) 
               |v == x = 1 + grauEmissao v as
               |otherwise = grauEmissao v as

grauRecepcao :: (Eq a) => a -> [(a,a)] -> Integer
grauRecepcao v [] = 0
grauRecepcao v ((x,y):as) 
                         |v == y = 1 + grauRecepcao v as
                         | otherwise = grauRecepcao v as
                         
sumidouro :: (Eq a ) => a -> [(a,a)] -> [Char]
sumidouro v ((o,d):as)
                      |grauEmissao v ((o,d):as) ==0 && grauRecepcao v((o,d):as) /= 0 = "Eh sumidouro"
                      | grauEmissao v ((o,d):as) /= 0 && grauRecepcao v ((o,d):as) == 0 = "Eh fonte"
                      |otherwise ="Nao eh nada"