﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HappyHoTel.Data;
using HappyHoTel.Models;

namespace HappyHoTel.control
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiPhongsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LoaiPhongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/LoaiPhongs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoaiPhong>>> GetLoaiPhongs()
        {
            return await _context.LoaiPhongs.ToListAsync();
        }

        // GET: api/LoaiPhongs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoaiPhong>> GetLoaiPhong(int id)
        {
            var loaiPhong = await _context.LoaiPhongs.FindAsync(id);

            if (loaiPhong == null)
            {
                return NotFound();
            }

            return loaiPhong;
        }

        // PUT: api/LoaiPhongs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoaiPhong(int id, LoaiPhong loaiPhong)
        {
            if (id != loaiPhong.LoaiPhongId)
            {
                return BadRequest();
            }

            _context.Entry(loaiPhong).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoaiPhongExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LoaiPhongs
        [HttpPost]
        public async Task<ActionResult<LoaiPhong>> PostLoaiPhong(LoaiPhong loaiPhong)
        {
            _context.LoaiPhongs.Add(loaiPhong);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoaiPhong", new { id = loaiPhong.LoaiPhongId }, loaiPhong);
        }

        // DELETE: api/LoaiPhongs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LoaiPhong>> DeleteLoaiPhong(int id)
        {
            var loaiPhong = await _context.LoaiPhongs.FindAsync(id);
            if (loaiPhong == null)
            {
                return NotFound();
            }

            _context.LoaiPhongs.Remove(loaiPhong);
            await _context.SaveChangesAsync();

            return loaiPhong;
        }

        private bool LoaiPhongExists(int id)
        {
            return _context.LoaiPhongs.Any(e => e.LoaiPhongId == id);
        }
    }
}
