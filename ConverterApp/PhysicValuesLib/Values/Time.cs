namespace PhysicValuesLib.Values;

internal class Time : AnyValue
{
    public Time()
    {
        ValueName = "Время";

        CoefficientsAndMeasuresList = new Dictionary<string, double>()
        {
            { "Секунды",        1       },
            { "Милисекунды",    0.001   },
            { "Минуты",         60      },
            { "Часы",           60 * 60 },
        };
    }
}
internal class distanse : AnyValue
{
    public distanse()
    {
        ValueName = "Расстояние";

        CoefficientsAndMeasuresList = new Dictionary<string, double>()
        {
            { "метр",        1       },
            { "Милиметр",    0.001   },
            { "сантиметр",   0.1     },
            { "километр",    1000    },
        };
    }
}
internal class weight : AnyValue
{
    public weight()
    {
        ValueName = "Масса";

        CoefficientsAndMeasuresList = new Dictionary<string, double>()
        {
            { "килограмм", 1      },
            { "грамм",     0.001  },
            { "центнер",   100    },
            { "тонна",     1000   },
        };
    }
}
internal class square : AnyValue
{
    public square()
    {
        ValueName = "Площадь";

        CoefficientsAndMeasuresList = new Dictionary<string, double>()
        {
            { "метр²",        1       },
            { "Милиметр²",    0.00001 },
            { "сантиметр²",   0.01    },
            { "километр²",    1000000 },
        };
    }
}
internal class speed : AnyValue
{
    public speed()
    {
        ValueName = "Скорость";

        CoefficientsAndMeasuresList = new Dictionary<string, double>()
        {
            { "метр в секунду",  1       },
            { "Миля в час",      2.237   },
            { "узел",            1.94384 },
            { "километр в час",  3.6     },
        };
    }
}
internal class ee : AnyValue
{
    public ee()
    {
        ValueName = "Давление";

        CoefficientsAndMeasuresList = new Dictionary<string, double>()
        {
            { "паскаль",    1          },
            { "бар",        100000     },
            { "атмосфера",  9.86923267 },
            { "торр",       0.00750062 },
        };
    }
}
internal class  r: AnyValue
{
    public r()
    {
        ValueName = "Объём данных";

        CoefficientsAndMeasuresList = new Dictionary<string, double>()
        {
            { "байт",        1         },
            { "бит",         8         },
            { "килобайт",    0.008     },
            { "мегабайт",    0.0000001 },
        };
    }
}