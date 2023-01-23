﻿using System;
using Foundation;
using UIKit;

namespace BigTed
{
    public static class ImageHelper
    {
        public static Lazy<UIImage?> ErrorImage { get; }
            = new Lazy<UIImage?>(() =>
                "iVBORw0KGgoAAAANSUhEUgAAADgAAAA4CAYAAACohjseAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAFaSURBVHgB7drbjcIwEIXho62A7SBbwbaYDraDhQooATqAEigFbEVHAil2wLeZkeaX5oEXlO8hiW0F8DzP87zipjDXMPcw+zA7yPcT5ozlmo5YrrE44jjxtyQy4m54vaZ/VHRfGSnkGi7OCRWdoQOZwsWZUVFEXCGLzOH2aJAksjuOSSCH4dhI5HAcG4EUw7GeSHEc64FUg2MtkepwrAVSLY7VINXjWAnSDI59gjSHY+8gJxjFsS2kaRzLIc3j2LtIkzi2heyO+0Lfdsi/B3+h4yCrqAnpB8rzXGAQmXvPmUfmcAek70kTyC1cLPfgUY38ZPn1DWPIkrWlGWTNwlk9ssWuQC2y5ZZHHbLHfk4NsudmVRw5Yicuhhx5zDAcKXGGMgwpeUDUHanh9KsrMvXHo3Ash5xRkQYcSyGrPkI4QQeOrSH/UNGEBRWhM3QUkQcsX4DM8DzP87zyHpoD8zEFezxGAAAAAElFTkSuQmCC"
                    .ToUIImage());
        
        public static Lazy<UIImage?> ErrorOutlineImage { get; }
            = new Lazy<UIImage?>(() => 
                "iVBORw0KGgoAAAANSUhEUgAAADYAAAA2CAYAAACMRWrdAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAOLSURBVHgBzZrrldMwEIXvUsFSwYoKSAmmAqCCNRWwHURUwFaAUwFbgukg0ABeGuDRAOCJLY6RZ+SRLMX5zpmTH7FkXc1Dsq0r5Kfq7Xlvu9GuezOT/3+O9tjbl96O4+9nXCBVb01vP3r7k2jd2IfBxpAn9lgnRrK2t1tsQI0ygjgvGiRwhTgMhnCpFNc+Ysgbyqdv3n83Y18uB5e47+3d2Fd2KDSWvEQh9BZxs7wb2xxRyHsh9oEbklgL3cwvYXo7LNwrW+41gRtZ5BHkYxAWuMdK3kMOix3KU4/34sZwh0Sk8DugjJckDGRxrxBJDTn0toAmkisulHNG24kBX/0stkUSd4QyglqmcYPLgARwYWmXGtbgC8U5c2oJAz6iTKhRF9tgI6gicpsDlhrpIXiNfAu0th8uZSruQt9b2i3MdK27RTp7xK1RFebCHjQXaby1Y9qliNtjXsY1tEy7/zx+QFpuGfDrXYy4PfiCpaHCwo7ErzIt9Fiki5O2bDE7CnHsVeKgpljEi2uENjXiOEAIR650pmxwLfTicokC+Gp+Gv8D5opTsVgWl1MUYSDkWYv0/OKwkMXlFuXw84xeJczWrwbrseAFlBBFsBr8G1nkweI8oojW67d9gnJYDG+WJN5gqGhFKCmMuEn8bzUkzH9Xl+sRheK8DvxvkeGlTIgSxUOqfpzlEOc/WZ80+OvYEesIlXSLMuLYAniPfAt0SJTDIq847gnjJcBvSSrEoxHlsMgnrmb6OW2pDARXRhAjymGRR1xwS9h5f7bQIz161Iq2Vmirfct7zbRtphfcIy0cd0gX5bBMe22e1xDyy1FhQbmAwTpRDuv10SnbdZp2LeaDNNAPima5Rjp20o/mCbqG0hkVc2FMrp0b31tBR3Bei/6icQYsIlOnAp/IBpfDC8zH+BWKMXIVktx+Ce/vn4EPwVtNY+mLhvpzTSEkUU1MJ7Q+cV80thIniVKFoE8NfvHtcL6co3MolFPcJCeJcnDvHF1BSf64reQp5O3ad2T4uC+Jc96rkBfy0mvIH9SziHLQWhY6ldNi/cESyt078GtplvCTMJBncerBBsNEaGbVHTciMaGJ+93bRxQuXBZhcX4uHseBT62Dvg8KvdL5/A+D8JGgHEaCLDZaOw3yCqSQ21SQj8Gw7rWIF+LEfMBQYbMIij2IqaXCcOCZdgw3mA+26+0XhkPOnzAc2szKX3FDRpE9g/z8AAAAAElFTkSuQmCC"
                    .ToUIImage());

        public static Lazy<UIImage?> ErrorOutlineFullImage { get; }
            = new Lazy<UIImage?>(() =>
                "iVBORw0KGgoAAAANSUhEUgAAADYAAAA2CAYAAACMRWrdAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAK2SURBVHgB1ZrBdZwwFEWfkwa8zC7KLru4BKUCuwMoYTqADuwKolSQOamA6cBxAyEVZJJlNiH6A+RgDAz60peYd86zFzM8/pU0EgiuEF7a+oP1TedrazX4/FfnH9ZP1o/d/2/YoLS1sT5aN0zXXYZCYlFPFPCDmXNlnSGBcsgATfWiQgQptK3ZRPY92hEiogxxeilq7xUAmg2YGjZDIBkAzcZcwFP3AJqNegemCiBZ0Wt9B0flAFIXvcb0m1NYKYW0s5+r6ZLsxVLwegJsb/0el6M31n+sD0tfynE5PTW2WgKrN1Ikx9UcVO4RWKIdwr7FPXRZNfN4PQXGCXscZZTMgpquYXvRZMCZwPZjKM0sZmqRLD2hen1m5BwxmiE5IWSDaZWeUKSaWdOzxvZZtzLw4fKZYwuPeqo+RHuEcOGoIe8EoJ4Nx51nkCscnfhGCKr3KX8fKGwNXAwo8ul3VgUMPAcXA4pM66HI1cYcXAwosoFAqAtcIXTuShLsHFwheN7qFeRE29hPC59fQVgSN5VLs99QpcC5/w/FOhGUJJyhO2iNcHfMNPw+YvrJiUF7RTAenge0w1IjnL7SH5rzpXvK4PyEUgaqg3xLgbkw1NTepDTcqRYlCFUsHCcFdxyG1ZGhJOHMMOghRIgj1Dm4ilnT7TBEM0N2nlBLcBywGgGDrj2hphpJMTPMFJhmhtVdYMU8fugKfg/pFWYUorhUNliQ3kiRrv6OFU9dQl2JxHSGFaLJoEb6YtfawEG06F7CM7JVQ3CsHECzYbOgeoXacwztn3C757sIuCBQvWg7egu/Oa/hNyeFdLPlX+svEHyfilQCiAlFQ4/9soqrFPjP1FyASgj30pwUwgLSkEsKNJZCu+5VcAfpYT6hvVYNAiS1G6vRvvD8zvotXhZbW/9GuxV3QPvic1D9A2S0YfDYEhUqAAAAAElFTkSuQmCC"
                    .ToUIImage());

        public static Lazy<UIImage?> SuccessImage { get; }
            = new Lazy<UIImage?>(() =>
                "iVBORw0KGgoAAAANSUhEUgAAADgAAAA4CAYAAACohjseAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAHTSURBVHgB7ZjBUcJQEIY/xotHSnh04NVbOHqjA7ACsQJTgXQgdEAH0oFePWEHaAVgdiAz+txkCElIsrxv5r8wzJB9++/7N0AgEAgEVB4SfR30jDHuE+1+aZsowgiDRJ/8L3CKAXqJZvwtzlQHpXs7RS8YQLrnW1O0SeQwQIxuTROzJ9aUOPALXGMAseYCvXsOA/iZlyrGAFrmXYQ1IwxwkZkn1nQYIEa35hgDmLfmEsPrmJZ5ptaxi8w8hwGGNLCO9dlvDI56ycu82hh7P1bnkMfo1hxRI9qJ3lA9jWWe9nIpRfepDrHmiobWsTn6ya6ojqzMG3MGpFNr9CIfKU9W5p11HZOZ26AXOaQcC1qyjk3RC5TTH3AaIxrIvDy0f5LTeexRHM2aja9jb+hFzijGEy1dxxzZl86x8+homTV9Ivan7T+gZOYx8/iObs0qs7U0WZeOPHzePE5oMPOKMqfYPDpakHlFyFsCJsr3FzS0jpXBoS8B/jxO0A+ildb0yQpssWN6cWjWXHJGrjidD/YXS+R9LsVdJ7pFf6e7S/RNh3hF72SrM68IeZeOb93OkvfmkcrRcbKWgLyM7Bzam0fr1rGySJHbg+QCchjFVNcCgUBA5QeEjGblSReLAQAAAABJRU5ErkJggg=="
                    .ToUIImage());
        
        public static Lazy<UIImage?> SuccessOutlineImage { get; }
            = new Lazy<UIImage?>(() => 
                "iVBORw0KGgoAAAANSUhEUgAAADYAAAA2CAYAAACMRWrdAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAOYSURBVHgBzZqNddMwEMf/7QRhgh4TkBHEBMAE9QaUCWImoCxAMgEZwWwQWICkC9CyAKB7tnmJfCdLlmT39961yYv1cV/SWfYV8mOsvLKy7mRlhc5+f+rkZOWHlUP3/zueIcbK1sqjlb8T5dj1QVgY9sQGacpo0li5xQJUKKOQ5EXCBK4QB6ENFxNw7Qlt3nA+PTi/3XR99Tk4xr2Vj11f2eHQGPMSh9B7xFl53bU5oJD3fGw8A7KyNcIsPwZZ2Y2MlS33tp6BauRRyIXgV3CDRD5BD4s1ylN1Y0lzuMNEtPDboYyXNAi6cm8RSQU99JaADSktLpxzFNoJQV79aiyLptwBgRHUCI23eB6wAlJY1mMNK8gLxZw5NQZBjijyNTrGNlgIXhGl4kCkwvIhuOrmYQKulVJGbOd6q0gJ44GcOYztUwZDxfYhF83trR0CQ+sM12uceytfp3PnlsE0w0rtLjztrjIh1spJShqoczcYan2L+dgkjr+DEo7S0jlHgcsQ0nO7gjL/PYYaz4U0NiEOgpBn1xhWFXMdg1UYVuef0R4pxHDC8MiA+A8nakooTIEgLxhTGehwjaHrH1CeWhj3NaZzcr7TNdLgMOaDmJgbPk5sd9XjE6gTMuMmXh3Yzr2F2AS2yxmCPY3TZ8MeexImHAJbns6+1xiv7zYYhuAHFGLq4rHC0Nu8XGt7ICF9z9I4SP26e8khosMaw8myoSSv7zG9bBpDTKd7pG3Qe4zfPlQoV7athb7faIMahKOdQ/T5Rii7V1ZQSiqC4soICPI5hIFcpBLy4S0JXYs2iMdAzrdUo/mQFrCLaLhHWjj2SHcKrqI5qaDkV4/BiOYRSEbqhZAXNyJEwzUZJyKd2NbIS4VAZxjhwim5xhAurcmfcx+6SvlL2sWS16KfaHSsurYV8itVIzJ1jNAg9/KcCt/euHP8iYA5SslfIpSm8BJyCN6GNNYqieDHNYXQlNrGdMIliVRJLKWcplRQCLpU0DdZwjzweyicU5KRJynVo1USj0h4uB3IC+gP938hw9mnr0xi7xnkhb30DvoD9SxK9fB+5Hsrp0H6/RXn7h3kvTRL+GkQdCuee3CL1hAhVu1fN2JlfIb7Y+UrCi9cNfzKubl46CZ+LkeE98GhVzqf/0PwvxKUQ1ihGgvtnYS8CnLILaqQC6Hd9xrEK9Ir8wXtCptFoSuUwaB94ZkrhhsMJ3u08hvtS87fUOB4+x9lZP+IMp/MjAAAAABJRU5ErkJggg=="
                    .ToUIImage ());
        
        public static Lazy<UIImage?> SuccessOutlineFullImage { get; }
            = new Lazy<UIImage?>(() => 
                "iVBORw0KGgoAAAANSUhEUgAAADYAAAA2CAYAAACMRWrdAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAALbSURBVHgB1ZrNldMwFIXvQAMs2fHYsSMd4A5mOrA7YDqwO0gqwKmAlODpINAAogICSzbj0Tt2cjyyHNvSk+Xcc25m8uOn9+k/ju4gr0T7s/am9Ttt6rz/t/Vv7Z/ax/bvD6xQiXapfdKuHa3aGITI4pbI4Qcz5Eo7RQRlCANka0XCAiI0tVkv7C2aHhJEKZZppUVbLwdQr8BcsSmEVAKoV+YcntoCqFfqRzgqB6IlPdUPmKkMQOykp5jHHGGiCHFnv7nmLVlvKXhrATtof8Lt6L32f+2nax/KcDstZZqugamVJOniaggqW0FyPF54pkva/+den9jAVOCkx8zlUycfnhDmTmIHEyoJmPBUp/Cv7BOMGXIfKNmpPlqgEsdYr3YksdctsoApx1iVb81IubBA5R7xLt3xMWDSY1YWKIJ/D9q80Q9fEE/FwGu+35YTfqgQp7VKS0KZUOwdB1PCCU/tgmRAkWAuJQIlPuYUfe0F41cQCFBgXndWFqgHQShvsNJIbjfxOupziQ+HioO6Tq2ZkRzPZGMb1wJ95YJAr8CU48WFJUm6UlEK/WmcAkBdetPB8eKh+w1D4yW1fFYFgLpU+s4jACdmW0wLWw0a+hoIin3PBWSeQXrfgVpVHXgy3uPnITfem3MhvoFyCxi1ULYbm/uAUKduQUogYGoB2Fhey4RBTJfdwnbwD3gaAOmKEH4Ld98tMBEKqnD9Ntg+EEy3/J4qoeDHAahEGGK0G4YoeGvE5iVBBYZiEwZUCRZStpXFC7bLPUKX8gaVLJBACP/ChF9dJGbIpZ1igpYaD1IuMUO8Ht3Cb2STuqCpDEC9YjtBnRXznuM1/8H4Lufm4ESgzuK1aA1jzqv7DYkQb7Z81v6OgOepWAWAJaG46zkfVpkrQvidOgMVCNxKQyLIAnKXiwpkitCsexXmg5xhvqHZq4oA3SGMEjQHnj9qf0A/WaX9D80h5yc0B59F9QKEbM3jilyzOgAAAABJRU5ErkJggg=="
                    .ToUIImage ());
        
        public static Lazy<UIImage?> InfoImage { get; }
            = new Lazy<UIImage?>(() => 
                "iVBORw0KGgoAAAANSUhEUgAAADgAAAA4CAYAAACohjseAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAEnSURBVHgB7dnNjcIwEAXgx+4WsNuBS2Er4cyNDigB0QFUgGiAMyegAn4qgCMnwozCAUWGgJg4Gut90rtYCGVkOxo7ABERERHVG0qOkkKykARkZISysPtsJb/IgBZRRHKRDNCwLzQvPBjvIMEMpihwLzlFxnUWd8iELsXqEl0hgW+ksZQcUC7JvWQq6UvOICLyrAN73VvqTFC+UV0JiLdlsSTpRa07me4bvw1w2GzrA2v79coMarMd0LAf2NKe8x/xB9fiZ8hYQAszmOI00SoW6B0L9I4FescCvWOB3rFA77Iv0Po8+CfpIX5Sr47pfZBe6Ve/W+iBeY7494zWrfH6ncyzLGDE+latgA39H5PtY70HJ3g8K+8Yw0hT96Kf0L23AREREVGdK5xoXf/nDhVfAAAAAElFTkSuQmCC"
                    .ToUIImage ());
        
        public static Lazy<UIImage?> InfoOutlineImage { get; }
            = new Lazy<UIImage?>(() => 
                "iVBORw0KGgoAAAANSUhEUgAAADYAAAA2CAYAAACMRWrdAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAObSURBVHgB3VrrddMwFP7a0/8tE1SdgDABYgLKBPUG7QYxE9AJcFiAlgVINki7AHEWILAAoIulnES+sh6WE8x3zm1PbL0+3Yce1yfID6nkpZKJlgslYuf9Dy21kmclS/3/Cf8gpJJKyUbJ70RZ6TYEjgzSxBT9yLhkruQGR0CBYQhxWhRIwAniINCYiwwoW6PxG/KntfXuUrdlfNCHeyXvdVvZQabh0xKZ0C3iZnmi6ywxkPa6MO3okMiWCJt5H4SSmaevbL5XdXRUIg8hGwLdBKfoiQ9wm8UEw6PQfXFjuEMiXOY3wzBackHATe4akSjgNr0UTHSbEmmgieSCC/mcCG1EgI9+JdJgm3NqdHORWyLQguZM5QppKOBeFlJABDizLH0VC/CBItWnuEkyktqmAG9RoqvSKraCBw/IT4xwhwgrKJDPBA1K5DXFXXDWILmCtrZSndw3gFztSrSJPYQU6qutXdB6U6LZE+ZcA+1J29jtz5DXtw4FCc+OxI4yOXzgUHCOXaLN+gbjwQyMOZ6B38w+oz8uwPtTjbxYYF8R28sje63ZoD8quNevFfKeDAQcfmZHlr7+NYGb1BARl2D72f0p2tGvRj/U8N9NCOSF3d/5GdPJGv07eYXGHM71M3N5OhRq7PMQZxgGNfbXkxKHOXFvcYr/FETMts9DHvsHA0fsHOODrYyaiD1ZDw/qC5lgj3lNxOwoKDAucIpYchojtUqMBxyxvxpbMC8kxoO31m+KGU9ErEZ7t/Ea4wBZl31p+kh/zDr2xXopMQ6tcTfBe8QemQJjOJNNrd81tJLMlmqhRe4UKtAk22rEQ2A/ul5a77kAtUAcCrQj+IIrKJHnmuwa/mMLJ9O4buLuQOdM4diMxgxpxFbhXbD3lVVXBclUiMpowH1f75P7wPbfMHW/2WPkkuvUwa31rEZzxvIdIA0k4iajRpiPXSn5yrRdKPnkq+zKaASnawbClWNcVUwjtE3hMhrHIuci1TLBEBRwO7nAYUCuQj7FTXISKQMuXWMCSnJyOxAv4E7uf0eG45WLnNGeRF6Qlt7BnVDPQsqA1rKur3Lm6L8FI9+9Q3cWtJf5uSDgnsVdDVZoJiJkVs3nRkSma+J+KfmMgQNXifBFlwa71APflRXC2yDTG9qftxBI3zrFECpxpLVTIC9BMrmjErIh0Kx7c8QTMWQ+oomwWQjFfogZConmg2faMVyiPdiVkp9o8nAL5M+Z4Q/aQY5WcvRpYAAAAABJRU5ErkJggg=="
                    .ToUIImage ());
        
        public static Lazy<UIImage?> InfoOutlineFullImage { get; }
            = new Lazy<UIImage?>(() =>
                "iVBORw0KGgoAAAANSUhEUgAAADYAAAA2CAYAAACMRWrdAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAKASURBVHgB3ZrfddMwFMZ/DX3gjTIBYgJ45FEjdINkhDKBs0GYgJQFoEzg8MhTywI4XYCWBerqVnZP/jlx7CvZ9XfOZ+c4Pvr8SVeydOUT9GEdPzh+LHjmaFb+vy+4dPzjeF2cb+ghrOPc8c4xb8isKMPQMaQlEtqZqWLqOKYDTAhjaFcrGiLA4Gszj8wZPkKCYEycVoraegmQ94BSsWOUMAfynjGhJWZA3lNe0BAJdPbQdXnOkZgoisvMwuI7vpwvFcu+44gBxaA3+mUVGl+Uyi8rrtarIFUUtRUaZ4oawikHMFEWNHu0sohaUcW0X/ZpldBEWUg4i6gltLvEskBiyYaOJdzU7Ac7xPKAzPChkgXWkQpbGyEvAwvG5NqMpMtZuzZTMTTCh2GwtU4HeMqznBY/tCHJmqrkjCHsqvg5eSQjiWYoZBx+cG3NrX42Qj8MF/jU2j58IyyMGDPowtS4556weHOKvjGLX3X/Wrl2Q9yEqJFDHoHTDWEbWC8dMVCIsdDx3gmGamwpxnq5y9ESt2LsluHhetAttmBYeJqnirElh6dALwlXcijfYz8ZDtaMXTEMLCkaqTS2YBh9bbHrokVnnlY75bwCuX+qoG2qBFKFwtusyNvkXub7Cra0N2aJb+wvG631aqPgpeNbx080h7TYb8fX+BCry4TmlfKZ9fXfTohIhk5/i8E5R0Bq/SXkGrdCsA4mQN5jNjJV4gLIe8h/KORD+2ZOxVSJc/rR51qFXxUM3Y2WD47fCbzHMAVimpLQa/yxyrEwhN9TE0NTOtoJMugalJDr1NAmDP69l3K8kdLMVxT36k4IA4v/4Pm94zu2HzZz/I//yHlBgNTEI4pNHaPOq5zVAAAAAElFTkSuQmCC"
                    .ToUIImage ());
        
        static UIImage? ToUIImage (this string base64String)
        {
            var imageBytes = Convert.FromBase64String(base64String);
            var imageData = NSData.FromArray(imageBytes);
            var uiImage = UIImage.LoadFromData(imageData);

            return uiImage;
        }
    }
}
