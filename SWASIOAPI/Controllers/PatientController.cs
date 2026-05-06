using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWASIOAPI.Data;
using SWASIOAPI.Models;

namespace SWASIOAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private readonly SwasioDbContext _context;

    public PatientController(SwasioDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetPatients()
    {
        var patients = await _context.Patients.ToListAsync();
        return Ok(patients);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePatient([FromBody] Patient patient)
    {
        if (string.IsNullOrWhiteSpace(patient.Name))
        {
            return BadRequest("Patient name is required.");
        }

        _context.Patients.Add(patient);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPatients), new { id = patient.Id }, patient);
    }
}