# Sablonok

## Összegzés

#### osszeg=SZUM(i=e..u, f(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: osszeg∈N
Ef: -
Uf: osszeg = SZUM(i=1..n, tomb[i])
```

## Feltételes összegzés

#### osszeg=SZUM(i=e..u, (fi), T(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: osszeg∈N
Ef: -
Uf: osszeg=SZUM(i=1..n, tomb[i], tomb[i]>10)
```

## Megszámlálás/Megszámolás

#### db=DARAB(i=e..u, T(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: db∈N
Ef: -
Uf: db=DARAB(i=1..n, tomb[i]>10)
```

## Maximum kiválasztás

#### (maxIndex, maxErtek)=MAX(i=e..u, f(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: maxIndex∈N,
    maxErtek∈N
Ef: n > 0
Uf: (maxIndex, maxErtek)=MAX(i=1..n, tomb[i])
```

## Minimum kiválasztás

#### (minIndex, minErtek)=MIN(i=e..u, f(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: minIndex∈N,
    minErtek∈N
Ef: n > 0
Uf: (minIndex, minErtek)=MIN(i=1..n, tomb[i])
```

## Feltételes maximum keresés

#### (van, maxIndex, maxErtek)=FELTMAX(i=e..u, f(i), T(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: van∈L,
    maxIndex∈N,
    maxErtek∈N
Ef: -
Uf: (van, maxIndex, maxErtek)=FELTMAX(i=1..n, tomb[i], tomb[i]>8)
```

## Feltételes minimum keresés

#### (van, minIndex, minErtek)=FELTMIN(i=e..u, f(i), T(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: van∈L,
    minIndex∈N,
    minErtek∈N
Ef: -
Uf: (van, minIndex, minErtek)=FELTMIN(i=1..n, tomb[i], tomb[i]>8)
```

## Keresés

#### (van, index)=KERES(i=e..u, T(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: van∈L,
    index∈N
Ef: -
Uf: (van, index)=KERES(i=1..n, tomb[i]>4)
```

## Eldöntés

#### van=VAN(i=e..u, T(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: van∈L
Ef: -
Uf: van=VAN(i=1..n, tomb[i]>80)
```

## Mind eldöntés/Optimista eldöntés

#### mind=MIND(i=e..u, T(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: mind∈L
Ef: -
Uf: mind=MIND(i=1..n, tomb[i]>2)
```

## Kiválasztás

#### ind=KIVÁLASZT(i>=e, T(i))

```
Be: szo∈S
Ki: ind∈N
Ef: ∃i∈[1..hossz(szo)]:(szo[i]="a")
Uf: ind=KIVÁLASZT(i>=1,szo[i]="a")
```

## Másolás

#### y=MÁSOL(i=e..u, f(i))

```
Be: n∈N,
    tomb∈N[1..n]
Ki: y∈N[1..n]
Ef: -
Uf: y=MÁSOL(i=1..n, tomb[i]+2)
```

## Kiválogat

#### (db, y)=KIVÁLOGAT(i=e..u, T(i), f(i))

```
Be: n∈N,
    diakok∈Diak[1..n],
    Diak=(nev:S x jegy:N)
Ki: db∈N,
    y∈S[1..db]
Ef: -
Uf: (db, y)=KIVÁLOGAT(i=1..n, diakok[i].jegy=5, diakok[i].nev)
```
