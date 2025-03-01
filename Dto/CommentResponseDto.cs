using Swashbuckle.AspNetCore.Annotations;

namespace api.Dto;

/// <summary>
/// DTO для представления комментария в ответе API.
/// </summary>
public class CommentResponseDto
{
    /// <summary>
    /// Идентификатор комментария.
    /// </summary>
    [SwaggerSchema(Description = "Уникальный идентификатор комментария.")]
    public Guid Id { get; set; } = Guid.Empty;

    /// <summary>
    /// Текст комментария.
    /// </summary>
    [SwaggerSchema(Description = "Текст комментария.")]
    public string Body { get; set; } = string.Empty;

    /// <summary>
    /// Дата и время создания комментария.
    /// </summary>
    [SwaggerSchema(Description = "Дата и время создания комментария в формате UTC.")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Информация о пользователе, создавшем комментарий.
    /// </summary>
    [SwaggerSchema(Description = "Информация о пользователе, создавшем комментарий.")]
    public UserNameDto User { get; set; } = null!;
}
