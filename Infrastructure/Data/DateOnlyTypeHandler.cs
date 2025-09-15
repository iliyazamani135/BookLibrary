using Dapper;

namespace Infrastructure.Data;

public class DateOnlyTypeHandler : SqlMapper.TypeHandler<DateOnly>
{
    public override DateOnly Parse(object value)
        => DateOnly.FromDateTime((DateTime)value);

    public override void SetValue(System.Data.IDbDataParameter parameter, DateOnly value)
        => parameter.Value = value.ToDateTime(TimeOnly.MinValue);
}
