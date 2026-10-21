# Slutkontrol af Mit dataoverblik den 20. oktober 2026

## Grundlag og omfang

Notatet er en opsummering af brugerens manuelle afprøvning i dialogen den 20. oktober og de delte skærmbilleder. AI har guidet og opsummeret; der er ikke udført en selvstændig kodeaudit eller automatisk UI-test i denne gennemgang. Præcise testtidspunkter er ikke registreret.

Kravgrundlag: Opgavekrav/Praktisk info og opgavekrav.docx i projektets dokumentmappe. Vurderingen gælder den afprøvede prototype, ikke en produktionsløsning.

## Build og automatiske tests

- Brugeren stod på main. Git viste den ajour med origin/main og kun azure-pipelines.yml.txt som untracked.
- Kommando: dotnet test MitDataoverblik.slnx --configuration Release.
- Skærmbilledet viste build succeeded og 2 tests bestået, 0 fejlet, 0 sprunget over.
- De to eksisterende tests dækker borgerhentning. De udgør ikke automatisk testdækning af login, formular, statusændringer eller brugerflade.

## Manuelt afprøvede forløb

| Kontrol | Observation | Resultat |
| --- | --- | --- |
| Start uden login | Ikke logget ind; administrationslink skjult | Bestået |
| Anna og optælling | Annas navn og adresse; 6 oplysninger, 3 myndigheder og 0 anmodninger efter genstart | Bestået |
| Søgning uden forskel på store og små bogstaver | Brugeren prøvede først små bogstaver og derefter særskilt ADRESSE; kun Folkeregisteradresse viste sig | Bestået |
| Kombineret søgning og filtre | Geodatastyrelsen, Tal og 750 viste kun Grundareal | Bestået |
| Ingen resultater | xyzxyz gav tydelig besked uden myndighedskort | Bestået |
| Nulstilling | Brugeren bekræftede tidligere i dagens forløb, at seks oplysninger kom tilbage | Bestået |
| Tom formular | Skærmbillede viste fejl for oplysning, rettelse og begrundelse uden oprettelsesbekræftelse | Bestået |
| Gyldig formular | Testvej 10, 8600 Silkeborg blev indsendt for Anna; bekræftelse Afventer og deaktiveret knap blev bekræftet | Bestået |
| Shared state og navigation | Samme anmodning viste sig på Mine anmodninger og forsiden; forsideantal 1 | Bestået |
| Administratorens visning | Annas anmodning med Borger-ID 1 og status Afventer blev vist | Bestået |
| Under behandling | Valget ændrede administratorens tekst; Anna så status med blå markering | Bestået |
| Oprindelig borgeroplysning | Folkeregisteradressen i myndighedskortet forblev Hovedgaden 1 | Bestået |
| Afsluttet | Valget ændrede administratorens tekst; Anna så Afsluttet med grøn markering | Bestået |
| Borgerens adgang til administration | Anna så ikke linket; navigation via historikken til /administration viste adgangsafvisning | Bestået |
| Bos egne data | Bo så Demovej 2, én oplysning og 0 anmodninger, uden Annas anmodning | Bestået |
| Bos formular | Kun Bos folkeregisteradresse var valgbar; nuværende værdi Demovej 2 | Bestået |
| Bos nye anmodning | Demovej 8 blev vist med Afventer; Annas anmodning var ikke på Bos oversigt | Bestået |
| Administratorens samlede liste | Anna/ID 1/Testvej 10/Afsluttet og Bo/ID 2/Demovej 8/Afventer blev begge bekræftet | Bestået |
| Logout | Retur via historikken til administration efter logout viste adgangsafvisning uden anmodninger | Bestået |
| Direkte formularadgang uden login | /opret-anmodning førte til /login med ReturnUrl og viste ikke formularen | Bestået |

## Sammenhold med de seks tekniske minimumskrav

| Krav | Eksempel i løsningen og grundlag |
| --- | --- |
| Komponenter | Myndighedskort og Anmodningskort genbruges. Parameteroverførsel er gennemgået under udviklingen. |
| Services og Dependency Injection | BorgerService, BorgeroplysningService og RettelsesanmodningService bruges af siderne. Registrering og injection er gennemgået under udviklingen. |
| Formular, model, binding og validering | Rettelsesanmodning og EditForm med inputfelter; tom og gyldig formular afprøvet i dag. |
| Håndtering og præsentation af data | Søgning, myndigheds- og datatypefilter samt resultatoptælling; afprøvet i dag. |
| Shared state | Borger/admin og forside/oversigt bruger samme anmodningsservice i det afprøvede browserforløb. |
| Authentication og authorization | Simuleret login med navn/rolle, egne data, adminadgang og logout; afprøvet i dag. |

De seks minimumsområder har konkrete eksempler i prototypen. Tabellen er en sporbar oversigt fra udviklingsdialog og afprøvning, ikke en garanti for alle mulige scenarier eller underviserens bedømmelse.

## Kendte afgrænsninger og resterende kontrol

- Demologin gælder den aktuelle interaktive forbindelse. Det udsteder ikke en logincookie og bevares ikke ved fuld genindlæsning.
- Anmodninger ligger i en scoped service i hukommelsen. De afprøvede brugerskift og sidevisninger foregik i samme fane via links/historik uden fuld genindlæsning. Deling mellem forskellige faner, forbindelser eller samtidige brugere er ikke bekræftet og må ikke påstås.
- Borgere hentes fra SQLite; borgeroplysninger og anmodninger er demodata i hukommelsen. Oprindelig tekst om, at alle data nulstilles ved genstart, skal afstemmes med denne forskel i præsentationen.
- Afventer-farve samt bred/smal visning blev afprøvet under PB07 den 19. oktober; mobilvisning blev ikke gentaget i dagens forløb.
- Tre-nyeste-begrænsningen på forsiden er ikke særskilt afprøvet med fire eller flere anmodninger i denne slutkontrol.
- Direkte URL-adgang som indlogget borger med bevaret login blev ikke særskilt afprøvet; rolleafvisning blev bekræftet via browserhistorikken. Fuld navigation starter en ny forbindelse og skal forklares i forhold til demologinets afgrænsning.

## Proces og aflevering der stadig mangler

- Sprint 2 review og retrospective er planlagt til 21. oktober og er endnu ikke gennemført.
- Færdiggør forklaringer af produktidé, målgruppe, tekniske valg, Scrum-proces, AI-støtte og kendte begrænsninger til den mundtlige præsentation.
- Præsentationen må ifølge opgavekravene højst vare 15 minutter. Prøvegennemgang med tid mangler.
- Forbered og kontrollér kildekodepakken til Wiseflow. Frist ifølge opgavekravene: fredag 23. oktober kl. 12.
- Feedbackforløbet før første vejledning behandles efter brugerens tidligere afklaring som allerede håndteret; der pålægges ikke en ny feedbackkontrakt i denne kontrol.
- Dokumentationsændringerne skal gennemgås og indgå i et særskilt Git-forløb. Dette notat er kun gemt lokalt ved oprettelsen.
