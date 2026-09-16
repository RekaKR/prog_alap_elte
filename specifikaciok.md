# Specifikációk, visszavezetés

## Összegzés
#### Sablon
```
osszeg=SZUM(i=e..u, f(i))
```

#### Specifikáció
```
Be: n∈N,
    tomb∈N[1..n]
Ki: osszeg∈N
Ef: -
Uf: osszeg = SZUM(i=1..n, tomb[i])
```

#### Visszavezetés
```
e..u    ~    1..n
f(i)    ~    tomb[i]
```

## Feltételes összegzés
#### Sablon
```
osszeg=SZUM(i=e..u, f(i), T(i))
```

#### Specifikáció
```
Be: n∈N,
    tomb∈N[1..n]
Ki: osszeg∈N
Ef: -
Uf: osszeg=SZUM(i=1..n, tomb[i], tomb[i]>10)
```

## Megszámlálás/Megszámolás
#### Sablon
```
db=DARAB(i=e..u, T(i))
```

#### Specifikáció
```
Be: n∈N,
    tomb∈N[1..n]
Ki: db∈N
Ef: -
Uf: db=DARAB(i=1..n, tomb[i]>10)
```

#### Visszavezetés
```
e..u    ~    1..n
T(i)    ~    tomb[i]>10
```

## Maximum kiválasztás
#### Sablon
```
(maxIndex, maxErtek)=MAX(i=e..u, f(i))
```

#### Specifikáció
```
Be: n∈N,
    tomb∈N[1..n]
Ki: maxIndex∈N,
    maxErtek∈N
Ef: n > 0
Uf: (maxIndex, maxErtek)=MAX(i=1..n, tomb[i])
```

#### Visszavezetés
```
maxIndex, maxErtek  ~    maxIndex, maxErtek
e..u                ~    1..n
f(i)                ~    tomb[i]
```

## Minimum kiválasztás
#### Sablon
```
(minIndex, minErtek)=MIN(i=e..u, f(i))
```

#### Specifikáció
```
Be: n∈N,
    tomb∈N[1..n]
Ki: minIndex∈N,
    minErtek∈N
Ef: n > 0
Uf: (minIndex, minErtek)=MIN(i=1..n, tomb[i])
```

## Feltételes maximum keresés
#### Sablon
```
(van, maxIndex, maxErtek)=FELTMAX(i=e..u, f(i), T(i))
```

#### Specifikáció
```
Be: n∈N,
    tomb∈N[1..n]
Ki: van∈L,
    maxIndex∈N,
    maxErtek∈N
Ef: -
Uf: (van, maxIndex, maxErtek)=FELTMAX(i=1..n, tomb[i], tomb[i]>8)
```

#### Visszavezetés
```
van, maxIndex, maxErtek  ~    van, maxIndex, maxErtek
e..u                     ~    1..n
f(i)                     ~    tomb[i]
T(i)                     ~    tomb[i]>8
```

## Feltételes minimum keresés
#### Sablon
```
(van, minIndex, minErtek)=FELTMIN(i=e..u, f(i), T(i))
```

#### Specifikáció
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
#### Sablon
```
(van, index)=KERES(i=e..u, T(i))
```

#### Specifikáció
```
Be: n∈N,
    tomb∈N[1..n]
Ki: van∈L,
    index∈N
Ef: -
Uf: (van, index)=KERES(i=1..n, tomb[i]>4)
```

#### Visszavezetés
```
van, index  ~    van, index
e..u        ~    1..n
T(i)        ~    tomb[i]>4
```

## Eldöntés
#### Sablon
```
van=VAN(i=e..u, T(i))
```

#### Specifikáció
```
Be: n∈N,
    tomb∈N[1..n]
Ki: van∈L
Ef: -
Uf: van=VAN(i=1..n, tomb[i]>80)
```

#### Visszavezetés
```
van     ~    van
e..u    ~    1..n
T(i)    ~    tomb[i]>80
```

## Mind eldöntés/Optimista eldöntés
#### Sablon
```
mind=MIND(i=e..u, T(i))
```

#### Specifikáció
```
Be: n∈N,
    tomb∈N[1..n]
Ki: mind∈L
Ef: -
Uf: mind=MIND(i=1..n, tomb[i]>2)
```

## Kiválasztás
#### Sablon
```
ind=KIVÁLASZT(i>=e, T(i))
```

#### Specifikáció
```
Be: szo∈S
Ki: ind∈N
Ef: ∃i∈[1..hossz(szo)]:(szo[i]="a")
Uf: ind=KIVÁLASZT(i>=1,szo[i]="a")
```

#### Visszavezetés
```
ind     ~    ind
i>=e    ~    i>=1
T(i)    ~    szo[i]="a"
```

## Másolás
#### Sablon
```
y=MÁSOL(i=e..u, f(i))
```

#### Specifikáció
```
Be: n∈N,
    tomb∈N[1..n]
Ki: y∈N[1..n]
Ef: -
Uf: y=MÁSOL(i=1..n, tomb[i]+2)
```

#### Visszavezetés
```
y     ~    y
e..u    ~    1..n
f(i)    ~    tomb[i]+2
```

## Kiválogat
#### Sablon
```
(db, y)=KIVÁLOGAT(i=e..u, T(i), f(i))
```

#### Specifikáció
```
Be: n∈N,
    diakok∈Diak[1..n],
    Diak=(nev:S x jegy:N)
Ki: db∈N,
    y∈S[1..db]
Ef: -
Uf: (db, y)=KIVÁLOGAT(i=1..n, diakok[i].jegy=5, diakok[i].nev)
```

#### Visszavezetés
```
db, y     ~      db, y
e..u      ~      1..n
T(i)      ~      diakok[i].jegy=5
f(i)      ~      diakok[i].nev
```
