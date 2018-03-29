using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

public class Role : IdentityRole<int>
{
    [Required(ErrorMessage = "ব্যবহারকারীর রোলের নাম লিখতে হবে"), MinLength(3, ErrorMessage = "ব্যবহারকারীর রোলের নাম ৩ অক্ষরের বড় হতে হবে"), MaxLength(50, ErrorMessage = "ব্যবহারকারীর রোলের নাম ৫০ অক্ষরের ছোট হতে হবে"), Display(Name = "ব্যবহারকারীর রোলের নাম", Prompt = "ব্যবহারকারীর রোলের নাম লিখুন")]
    public string Description { get; set; }
}