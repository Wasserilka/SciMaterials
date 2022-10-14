﻿using Microsoft.AspNetCore.Mvc;
using SciMaterials.Contracts.API.Constants;
using SciMaterials.Contracts.API.DTO.Tags;
using SciMaterials.Contracts.API.Services.Tags;

namespace SciMaterials.UI.MVC.API.Controllers;

/// <summary> Service for working with authors. </summary>
[ApiController]
[Route(WebApiRoute.Tags)]
public class TagsController : ApiBaseController<CategoriesController>
{
    private readonly ITagService _authorService;

    public TagsController(ITagService authorService)
    {
        _authorService = authorService;
    }

    /// <summary> Get All Categories. </summary>
    /// <returns> Status 200 OK. </returns>
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var сategories = await _authorService.GetAllAsync();
        return Ok(сategories);
    }

    /// <summary> Get Tag by Id. </summary>
    /// <param name="id"> Tag Id. </param>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        var products = await _authorService.GetByIdAsync(id);
        return Ok(products);
    }

    /// <summary> Add a Tag. </summary>
    /// <param name="request"> Add Request DTO. </param>
    /// <returns> Status 200 OK. </returns>
    [HttpPost("Add")]
    public async Task<IActionResult> AddAsync([FromBody] AddTagRequest request)
    {
        return Ok(await _authorService.AddAsync(request));
    }

    /// <summary> Edit a Tag. </summary>
    /// <param name="request"> Edit Request DTO. </param>
    /// <returns> Status 200 OK. </returns>
    [HttpPost("Edit")]
    public async Task<IActionResult> EditAsync([FromBody] EditTagRequest request)
    {
        return Ok(await _authorService.EditAsync(request));
    }

    /// <summary> Delete a Tag. </summary>
    /// <param name="id"> Tag Id. </param>
    /// <returns> Status 200 OK response. </returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await _authorService.DeleteAsync(id));
    }
}