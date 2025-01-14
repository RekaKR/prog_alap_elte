# Sablonok

## Összegzés

osszeg=SZUM(i=e..u, f(i))

## Feltételes összegzés

osszeg=SZUM(i=e..u, (fi), T(i))

## Megszámlálás/Megszámolás

db=DARAB(i=e..u, T(i))

## Maximum kiválasztás

(maxIndex, maxErtek)=MAX(i=e..u, f(i))

## Minimum kiválasztás

(minIndex, minErtek)=MIN(i=e..u, f(i))

## Feltételes maximum keresés

(van, maxIndex, maxErtek)=FELTMAX(i=e..u, f(i), T(i))

## Feltételes minimum keresés

(van, minIndex, minErtek)=FELTMIN(i=e..u, f(i), T(i))

## Keresés

(van, index)=KERES(i=e..u, T(i))

## Eldöntés

van=VAN(i=e..u, T(i))

## Mind eldöntés/Optimista eldöntés

mind=MIND(i=e..u, T(i))

## Kiválasztás

ind=KIVÁLASZT(i>=e, T(i))

## Másolás

y=MÁSOL(i=e..u, f(i))

## Kiválogat

(db, y)=KIVÁLOGAT(i=e..u, T(i), f(i))
