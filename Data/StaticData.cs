﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public static class Extensions
    {
        public static List<T> GetRandomElements<T>(this IEnumerable<T> list, int elementsCount)
        {
            return list.OrderBy(arg => Guid.NewGuid()).Take(elementsCount).ToList();
        }

        public static IEnumerable<(T item, int index)> Enumerated<T>(this IEnumerable<T> self) => self?.Select((item, index) => (item, index)) ?? new List<(T, int)>();
    }

    public class StaticData
    {
        public List<CortexSceneTrait> SceneTraitList = new()
        {
            new CortexSceneTrait
            {
                Name = "Patrons",
                Type = "Agent"
            },
            new CortexSceneTrait
            {
                Name = "Witchlock Pistol",
                Type = "Asset"
            },
            new CortexSceneTrait
            {
                Name = "Witchlock Rifle",
                Type = "Asset"
            },
            new CortexSceneTrait
            {
                Name = "In the Mines",
                Type = "Title"
            },
            new CortexSceneTrait
            {
                Name = "Bandits",
                Type = "Agent"
            },
            new CortexSceneTrait
            {
                Name = "Information",
                Type = "Asset"
            },
            new CortexSceneTrait
            {
                Name = "On the Train",
                Type = "Title"
            },
            new CortexSceneTrait
            {
                Name = "Off World",
                Type = "Title"
            },
            new CortexSceneTrait
            {
                Name = "Soldiers",
                Type = "Agent"
            },
            new CortexSceneTrait
            {
                Name = "Medicine",
                Type = "Asset"
            },
            new CortexSceneTrait
            {
                Name = "Between Worlds",
                Type = "Title"
            },
            new CortexSceneTrait
            {
                Name = "Worshipers",
                Type = "Agent"
            },
            new CortexSceneTrait
            {
                Name = "Holy Relic",
                Type = "Asset"
            },
            new CortexSceneTrait
            {
                Name = "In the Desert",
                Type = "Title"
            },
            new CortexSceneTrait
            {
                Name = "Innocents",
                Type = "Asset"
            },
            new CortexSceneTrait
            {
                Name = "Lightning",
                Type = "Asset"
            },
            new CortexSceneTrait
            {
                Name = "At the Saloon",
                Type = "Title"
            },
            new CortexSceneTrait
            {
                Name = "Workers",
                Type = "Agent"
            },
            new CortexSceneTrait
            {
                Name = "Fire",
                Type = "Asset"
            },
            new CortexSceneTrait
            {
                Name = "Leaving the Station",
                Type = "Title"
            },
            new CortexSceneTrait
            {
                Name = "An Official",
                Type = "Agent"
            },
            new CortexSceneTrait
            {
                Name = "Stranger",
                Type = "Agent"
            },
            new CortexSceneTrait
            {
                Name = "a Local",
                Type = "Agent"
            },
            new CortexSceneTrait
            {
                Name = "Water",
                Type = "Asset"
            },
            new CortexSceneTrait
            {
                Name = "Whiskey",
                Type = "Asset"
            },
            new CortexSceneTrait
            {
                Name = "Helpin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Believin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Bossin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Laborin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Fiddlin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Learnin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Fightin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Rushin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Slingin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Occultin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Shankin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Cheatin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Yakkin",
                Type = "Trait"
            },
            new CortexSceneTrait
            {
                Name = "Gamblin",
                Type = "Trait"
            },

        };

        public List<CortexTrait> GMCTraitList = new()
        {
            new CortexTrait
            {
                Name = "Patron",
                Type = "Agent"
            },
            new CortexTrait
            {
                Name = "Witchlock Pistol",
                Type = "Asset"
            },
            new CortexTrait
            {
                Name = "Witchlock Rifle",
                Type = "Asset"
            },
                        new CortexTrait
            {
                Name = "Tinkerer", Subtype="Mind",
                Type = "Distinction"
            },
                        new CortexTrait
            {
                Name = "Homesteader", Subtype="Mind",
                Type = "Distinction"
            },
                        new CortexTrait
            {
                Name = "Expansionist",
                        Subtype = "Mind",
                        Type = "Distinction"
            },
                        new CortexTrait
            {
                Name = "Soldier",
                Subtype = "Mind",
                Type = "Distinction"
                        },
            new CortexTrait
            {
                Name = "Academic",
                        Subtype = "Mind",
                        Type = "Distinction"
            },
            new CortexTrait
            {
                Name = "Spiritualist",
                        Subtype = "Mind",
                        Type = "Distinction"
            },
            new CortexTrait
                        {
                            Name = "Opportunist",
                            Subtype = "Mind",
                            Type = "Distinction"
            },
            new CortexTrait
            {
                Name = "Bandit",
                Type = "Agent"
            },
            new CortexTrait
            {
                Name = "Information",
                Type = "Asset"
            },
            new CortexTrait
            {
                Name = "Soldier",
                Type = "Agent"
            },
            new CortexTrait
            {
                Name = "Medicine",
                Type = "Asset"
            },
            new CortexTrait
            {
                Name = "Worshiper",
                Type = "Agent"
            },
            new CortexTrait
            {
                Name = "Holy Relic",
                Type = "Asset"
            },
            new CortexTrait
            {
                Name = "Innocent",
                Type = "Asset"
            },
            new CortexTrait
            {
                Name = "Lightning",
                Type = "Asset"
            },
            new CortexTrait
            {
                Name = "Worker",
                Type = "Agent"
            },
            new CortexTrait
            {
                Name = "Fire",
                Type = "Asset"
            },
            new CortexTrait
            {
                Name = "An Official",
                Type = "Agent"
            },
            new CortexTrait
            {
                Name = "Stranger",
                Type = "Agent"
            },
            new CortexTrait
            {
                Name = "a Local",
                Type = "Agent"
            },
            new CortexTrait
            {
                Name = "Water",
                Type = "Asset"
            },
            new CortexTrait
            {
                Name = "Whiskey",
                Type = "Asset"
            },
            new CortexTrait
            {
                Name = "Helpin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Believin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Bossin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Laborin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Fiddlin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Learnin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Fightin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Rushin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Slingin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Occultin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Shankin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Cheatin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Yakkin",
                Type = "Trait"
            },
            new CortexTrait
            {
                Name = "Gamblin",
                Type = "Trait"
            },
            new CortexTrait {Name="Preserved",Type="Distinction",Subtype = "Skin"},
            new CortexTrait {Name= "Sculpted", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Ephemeral", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Exoskeleton", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Scaled", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Human", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Furred", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Horned", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Built", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Grown", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Decaying", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Inked", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Feathered", Type = "Distinction", Subtype = "Skin" },
            new CortexTrait {Name= "Bleeding Heart", Type = "Distinction", Subtype = "Soul" },
            new CortexTrait {Name= "Corrupt", Type = "Distinction", Subtype = "Soul" },
            new CortexTrait {Name= "Inventive", Type = "Distinction", Subtype = "Soul" },
            new CortexTrait {Name= "Enlightened", Type = "Distinction", Subtype = "Soul" },
            new CortexTrait {Name= "Wistful", Type = "Distinction", Subtype = "Soul" },
            new CortexTrait {Name= "Cunning", Type = "Distinction", Subtype = "Soul" },
            new CortexTrait
            {
                Name = "Heroic",
                Type = "Distinction",
                Subtype = "Soul"
            },
        };

        public SVGFaces Faces = new();

        public List<CortexTrait> DistinctionTraitList = new();
    }

    public static class StaticDataExtensions
    {
        public static string GetShapePath(string descriptor)
        {
            if (string.IsNullOrEmpty(descriptor))
                return "M119.436 36c-16.126 0-29.2 17.237-29.2 38.5v363c0 21.263 13.074 38.5 29.2 38.5h275.298c16.126 0 29.198-17.237 29.198-38.5v-363c0-21.263-13.072-38.5-29.198-38.5zm26.369 10.951l11.002 32.856 34.648.312-27.848 20.617 10.41 33.05-28.212-20.114-28.215 20.113L128 100.736 100.152 80.12l34.649-.312zM363.979 161.84c7.127 9.459 12.739 20.689 16.832 32.04 3.8 10.544 6.197 21.211 6.668 31.02-.163 19.015-3.915 23.274-14.557 36.934l-6.703-11.48c-10.85-13.106-30.779-48.4-47.383-43.672-6.521 6.11-8.996 13.37-10.313 20.802 2.898 8.8 4.477 18.43 4.477 28.516 0 15.293-3.615 29.54-9.996 41.416 22.643 4.537 57.927 19.332 57.973 39.223-.27 3.783-1.835 7.68-4.362 10.42-10.743 12.528-36.958 4.125-45.2 10.072.796 6.947 4.112 14.118 4.355 20.174.136 4.36-1.768 10.58-6.508 13.996-5.67 4.087-12.968 4.551-18.52 3.045C279.94 392.226 272 379.649 256 377c-13.544 3.491-22.412 13.87-34.742 17.346-5.552 1.506-12.85 1.042-18.52-3.045-4.74-3.417-6.644-9.636-6.508-13.996-.058-7.142 4.107-13.794 4.356-20.174-15.741-7.788-33.816 1.97-45.201-10.072-2.527-2.74-4.093-6.637-4.362-10.42 6.146-27.341 35.374-34.684 57.973-39.223C202.615 285.54 199 271.293 199 256c0-11.489 2.047-22.385 5.764-32.135-2.357-7.923-3.441-15.988-9.438-22.441-8.758-.925-14.079 6.897-17.842 12.63-11.683 19.5-18.718 30.606-32.88 46.192-16.604-23.4-19.314-49.29-13.157-70.988 6.065-20.331 19.17-38.798 37.926-47.924 21.216-9.766 39.872-10.03 58.885.203 5.163-13.053 10.4-25.65 18.035-36.209 9.625-13.31 23.8-25.631 43.707-25.295 38.8.656 73.993 51.156 73.979 81.807zm-72.22-63.893c-35.759 2.409-44.771 44.746-55.189 71.29l-9.447-7.087c-18.428-12.31-31.076-13.732-49.875-4.63-12.924 6.288-23.701 20.62-28.553 36.882-3.38 11.329-3.765 23.225-.949 33.645 9.45-13.549 15.806-30.08 28.317-39.178 7.486-7.975 26.27-8.498 35.45 3.897 4.838 7.02 7.437 14.54 9.5 22.234h72.165c.592-1.944 1.067-3.762 2.017-6.033 2.956-7.064 7.765-16.266 18.395-19.504 18.09-3.862 32.494 7.106 43.498 18.514 4.517 4.717 8.492 9.696 12.098 14.517-.69-6.798-2.477-14.651-5.31-22.508-13.127-36.707-37.889-51.031-70.386-32.011 2.556-16.423 16.87-35.72 46.25-26.962-9.094-17.135-30.355-42.471-47.98-43.066zM220.644 233c-2.31 6.965-3.643 14.753-3.643 23 0 15.85 4.892 30.032 12.26 39.855C236.628 305.68 245.988 311 256 311c10.012 0 19.372-5.32 26.74-15.145C290.108 286.032 295 271.85 295 256c0-8.247-1.334-16.035-3.643-23zM232 280h48s-8 14-24 14-24-14-24-14zm-11.14 33.566c-13.86 3.34-50.369 8.9-51.842 21.42 9.621 1.947 20.446.838 28.998 2.235 5.993 1.018 12.82 3.323 17.285 9.517 3.375 4.683 3.577 10.103 3.037 14.21-.543 5.89-3.317 10.557-3.975 16.32 15.955-2.59 28.264-17.532 41.637-18.268 16-.702 29.313 17.402 41.637 18.268-.893-5.59-3.262-11.158-3.975-16.32-.54-4.107-.338-9.527 3.037-14.21 4.465-6.194 11.292-8.5 17.285-9.517 9.742-2.229 19.975.396 28.998-2.235-5.77-13.125-39.813-19.454-51.841-21.42C281.665 323.01 269.45 329 256 329c-13.452 0-25.665-5.991-35.14-15.434zm117.122 64.649l28.213 20.113 28.215-20.113L384 411.264l27.848 20.617-34.649.312-11.004 32.856-11.002-32.856-34.648-.312 27.848-20.617z";

            switch (descriptor)
            {
                case "Helpin":
                case "Believin":
                    return "M480.25 156.355c0 161.24-224.25 324.43-224.25 324.43S31.75 317.595 31.75 156.355c0-91.41 70.63-125.13 107.77-125.13 77.65 0 116.48 65.72 116.48 65.72s38.83-65.73 116.48-65.73c37.14.01 107.77 33.72 107.77 125.14z";
                case "Bossin":
                case "Laborin":
                    return "M458.915 307.705c0 62.63-54 91.32-91.34 91.34-41.64 0-73.1-18.86-91.83-34.26 2.47 50.95 14.53 87.35 68.65 116h-176.79c54.12-28.65 66.18-65.05 68.65-116-18.73 15.39-50.2 34.28-91.83 34.26-37.29 0-91.34-28.71-91.34-91.34 0-114.47 80.64-83.32 202.91-276.49 122.28 193.17 202.92 162.03 202.92 276.49z";
                case "Fiddlin":
                case "Learnin":
                    return "M477.443 295.143a104.45 104.45 0 0 1-202.26 36.67c-.08 68.73 4.33 114.46 69.55 149h-177.57c65.22-34.53 69.63-80.25 69.55-149a104.41 104.41 0 1 1-66.34-136.28 104.45 104.45 0 1 1 171.14 0 104.5 104.5 0 0 1 135.93 99.61z";
                case "Fightin":
                case "Rushin":
                    return "M256 26C129.17 26 26 129.17 26 256s103.192 230 230 230 230-103.192 230-230S382.83 26 256 26zm168.813 174.7H298.258L257.442 78.36c78.035.628 144.206 51.81 167.37 122.34zM254.558 78.36L213.786 200.7H87.23C110.353 130.17 176.524 78.99 254.56 78.36zM78.328 256a177.056 177.056 0 0 1 7.637-51.49l101.728 75.932-37.34 118.345A177.518 177.518 0 0 1 78.33 256zm76.66 146.045L256 330.03l101.013 72.015a177.177 177.177 0 0 1-202.026 0zm206.614-3.302l-37.295-118.345 101.728-75.933a177.463 177.463 0 0 1-64.39 194.322z";
                case "Slingin":
                case "Occultin":
                    return "M261.938 16.28c-44.12 0-84.047 5.327-113.72 14.282-14.835 4.478-27.12 9.802-36.374 16.407-9.238 6.59-16.223 15.3-16.25 26l-.03.03c0 13.315 1.05 26.348 3.03 39 3.29-1.478 6.858-2.368 10.562-2.5 1.437-.05 2.874.004 4.344.188 11.763 1.47 21.494 9.193 28.688 19.187 7.193 9.994 12.08 22.69 13.437 36.375 1.357 13.686-1.013 26.1-7.063 35.594-2.544 3.994-5.964 7.404-9.937 9.937 30.266 41.24 74.044 67.345 123.313 67.345 48.71 0 92.033-25.536 122.25-65.97-4.95-2.59-9.168-6.572-12.188-11.31-6.05-9.495-8.42-21.91-7.063-35.595 1.357-13.686 6.276-26.38 13.47-36.375 7.193-9.994 16.893-17.718 28.656-19.188.735-.09 1.464-.157 2.187-.187.723-.03 1.438-.026 2.156 0 4.872.174 9.506 1.677 13.594 4.094 2.143-13.137 3.28-26.702 3.28-40.563V73c-.012-10.712-7.002-19.433-16.25-26.03-9.254-6.606-21.538-11.93-36.374-16.407-29.672-8.956-69.6-14.282-113.72-14.282zM152.78 48.72c-4.477 3.726-6.936 7.742-6.936 11.936 0 19.348 51.99 35.032 116.094 35.032C326.04 95.688 378 80 378 60.656c0-4.2-2.48-8.206-6.97-11.937 13.2 4.046 23.653 8.826 30.158 13.468 6.634 4.734 8.406 8.483 8.406 10.843 0 2.36-1.772 6.11-8.406 10.845-6.635 4.734-17.36 9.62-30.938 13.72-27.155 8.194-65.717 13.468-108.313 13.468-42.595 0-81.157-5.274-108.312-13.47-13.577-4.097-24.303-8.984-30.938-13.718-6.634-4.734-8.406-8.484-8.406-10.844 0-2.36 1.773-6.108 8.407-10.843 6.495-4.634 16.922-9.425 30.094-13.468zm-43.25 79.405c-.522-.007-1.012.024-1.5.094-2.917.418-5.155 2.195-7.5 5.874-3.124 4.904-5.242 13.385-4.218 23.72.818 8.25 3.468 16.2 7.094 22.686 1.035-8.94 8.625-15.875 17.844-15.875 6.984 0 13.026 3.994 16 9.813.1-2.316.036-4.772-.22-7.344-1.023-10.334-4.93-20.226-10.03-27.313-5.1-7.086-11.195-10.953-15.813-11.53-.577-.072-1.133-.118-1.656-.125zm301.5 0c-.522.007-1.078.053-1.655.125-4.618.577-10.71 4.444-15.813 11.53-5.1 7.088-9.006 16.98-10.03 27.314-.158 1.58-.234 3.105-.25 4.594 3.29-4.295 8.456-7.063 14.28-7.063 9.926 0 17.97 8.043 17.97 17.97 0 .23-.023.457-.032.686 4.477-6.908 7.81-15.998 8.75-25.468 1.024-10.333-1.094-18.814-4.22-23.718-2.342-3.68-4.58-5.456-7.5-5.875-.485-.07-.976-.102-1.5-.095zm-148.905 11.813c11.85 0 22.082 6.965 28.75 16.53 6.668 9.566 10.406 21.998 10.406 35.563 0 13.566-3.737 25.998-10.405 35.564-6.668 9.565-16.9 16.53-28.75 16.53-11.85 0-22.05-6.965-28.72-16.53C226.74 218.028 223 205.597 223 192.03c0-13.564 3.74-25.996 10.406-35.56 6.668-9.567 16.868-16.532 28.72-16.532zm0 18.687c-4.606 0-9.29 2.624-13.406 8.53-4.12 5.908-7.032 14.83-7.032 24.876 0 4.65.64 9.052 1.718 13.032 1.935-7.837 8.97-13.656 17.406-13.656 9.926 0 17.97 8.043 17.97 17.97 0 .62-.033 1.24-.094 1.843 2.38-5.356 3.906-11.975 3.906-19.19 0-10.044-2.945-18.967-7.063-24.874-4.116-5.907-8.8-8.53-13.405-8.53zm-39.22 128.72c-1.274 6.034-2.6 11.995-4 17.81.5.183 1.005.357 1.532.533 9.685 3.217 24.14 5.437 40.125 5.437 15.77 0 30.07-2.166 39.75-5.313-1.495-5.43-2.922-10.995-4.312-16.625-9.97 2.145-21.07 3.344-32.78 3.344-14.76 0-28.546-1.884-40.314-5.186zm-8.655 35.967c-11.726 42.656-26.91 77.18-44.656 95.375.498 1.15 1.65 2.71 4.125 4.72 3.802 3.088 10.298 6.512 18.718 9.406 16.838 5.787 41.21 9.625 68.125 9.625 26.913 0 51.317-3.838 68.156-9.625 8.418-2.894 14.914-6.318 18.717-9.407 3.163-2.568 4.162-4.385 4.407-5.562-17.226-18.314-33.287-52.22-46.28-94.094-12.233 3.898-27.832 6.063-45.002 6.063-17.664 0-33.65-2.294-46.03-6.407-.096-.03-.187-.062-.282-.094zm152.563 106.25c-2 3.152-4.644 5.948-7.594 8.344-6.39 5.19-14.64 9.226-24.44 12.594-19.6 6.737-45.566 10.625-74.217 10.625-28.652 0-54.588-3.888-74.188-10.625-9.8-3.368-18.05-7.405-24.438-12.594-2.89-2.348-5.484-5.082-7.468-8.156-.4.18-.788.398-1.19.563-11.745 4.817-21.073 11.418-23.468 21.53-4.48 18.93 58.848 38.31 131.875 38.313 73.028.002 132.407-17.273 132.407-38.312 0-8.636-11.4-13.37-27.28-22.28z";
                case "Shankin":
                case "Cheatin":
                    return "M253.125 18.563c-131.53 0-238.375 106.813-238.375 238.343 0 131.53 106.846 238.344 238.375 238.344 131.53 0 238.344-106.815 238.344-238.344 0-131.528-106.816-238.344-238.345-238.344zm-23.938 52.093c40.517 0 77.988 12.904 108.532 34.813-5.597-.624-11.302-.97-17.064-.97-84.157 0-152.375 68.25-152.375 152.406 0 84.157 68.22 152.375 152.376 152.375 5.762 0 11.467-.313 17.063-.936-30.545 21.91-68.016 34.812-108.533 34.812-102.98 0-186.28-83.272-186.28-186.25 0-102.977 83.3-186.25 186.28-186.25z";
                case "Yakkin":
                case "Gamblin":
                    return "M431.76 256c-69 42.24-137.27 126.89-175.76 224.78C217.51 382.89 149.25 298.24 80.24 256c69-42.24 137.27-126.89 175.76-224.78C294.49 129.11 362.75 213.76 431.76 256z";
                case null:
                default:
                    return "M119.436 36c-16.126 0-29.2 17.237-29.2 38.5v363c0 21.263 13.074 38.5 29.2 38.5h275.298c16.126 0 29.198-17.237 29.198-38.5v-363c0-21.263-13.072-38.5-29.198-38.5zm26.369 10.951l11.002 32.856 34.648.312-27.848 20.617 10.41 33.05-28.212-20.114-28.215 20.113L128 100.736 100.152 80.12l34.649-.312zM363.979 161.84c7.127 9.459 12.739 20.689 16.832 32.04 3.8 10.544 6.197 21.211 6.668 31.02-.163 19.015-3.915 23.274-14.557 36.934l-6.703-11.48c-10.85-13.106-30.779-48.4-47.383-43.672-6.521 6.11-8.996 13.37-10.313 20.802 2.898 8.8 4.477 18.43 4.477 28.516 0 15.293-3.615 29.54-9.996 41.416 22.643 4.537 57.927 19.332 57.973 39.223-.27 3.783-1.835 7.68-4.362 10.42-10.743 12.528-36.958 4.125-45.2 10.072.796 6.947 4.112 14.118 4.355 20.174.136 4.36-1.768 10.58-6.508 13.996-5.67 4.087-12.968 4.551-18.52 3.045C279.94 392.226 272 379.649 256 377c-13.544 3.491-22.412 13.87-34.742 17.346-5.552 1.506-12.85 1.042-18.52-3.045-4.74-3.417-6.644-9.636-6.508-13.996-.058-7.142 4.107-13.794 4.356-20.174-15.741-7.788-33.816 1.97-45.201-10.072-2.527-2.74-4.093-6.637-4.362-10.42 6.146-27.341 35.374-34.684 57.973-39.223C202.615 285.54 199 271.293 199 256c0-11.489 2.047-22.385 5.764-32.135-2.357-7.923-3.441-15.988-9.438-22.441-8.758-.925-14.079 6.897-17.842 12.63-11.683 19.5-18.718 30.606-32.88 46.192-16.604-23.4-19.314-49.29-13.157-70.988 6.065-20.331 19.17-38.798 37.926-47.924 21.216-9.766 39.872-10.03 58.885.203 5.163-13.053 10.4-25.65 18.035-36.209 9.625-13.31 23.8-25.631 43.707-25.295 38.8.656 73.993 51.156 73.979 81.807zm-72.22-63.893c-35.759 2.409-44.771 44.746-55.189 71.29l-9.447-7.087c-18.428-12.31-31.076-13.732-49.875-4.63-12.924 6.288-23.701 20.62-28.553 36.882-3.38 11.329-3.765 23.225-.949 33.645 9.45-13.549 15.806-30.08 28.317-39.178 7.486-7.975 26.27-8.498 35.45 3.897 4.838 7.02 7.437 14.54 9.5 22.234h72.165c.592-1.944 1.067-3.762 2.017-6.033 2.956-7.064 7.765-16.266 18.395-19.504 18.09-3.862 32.494 7.106 43.498 18.514 4.517 4.717 8.492 9.696 12.098 14.517-.69-6.798-2.477-14.651-5.31-22.508-13.127-36.707-37.889-51.031-70.386-32.011 2.556-16.423 16.87-35.72 46.25-26.962-9.094-17.135-30.355-42.471-47.98-43.066zM220.644 233c-2.31 6.965-3.643 14.753-3.643 23 0 15.85 4.892 30.032 12.26 39.855C236.628 305.68 245.988 311 256 311c10.012 0 19.372-5.32 26.74-15.145C290.108 286.032 295 271.85 295 256c0-8.247-1.334-16.035-3.643-23zM232 280h48s-8 14-24 14-24-14-24-14zm-11.14 33.566c-13.86 3.34-50.369 8.9-51.842 21.42 9.621 1.947 20.446.838 28.998 2.235 5.993 1.018 12.82 3.323 17.285 9.517 3.375 4.683 3.577 10.103 3.037 14.21-.543 5.89-3.317 10.557-3.975 16.32 15.955-2.59 28.264-17.532 41.637-18.268 16-.702 29.313 17.402 41.637 18.268-.893-5.59-3.262-11.158-3.975-16.32-.54-4.107-.338-9.527 3.037-14.21 4.465-6.194 11.292-8.5 17.285-9.517 9.742-2.229 19.975.396 28.998-2.235-5.77-13.125-39.813-19.454-51.841-21.42C281.665 323.01 269.45 329 256 329c-13.452 0-25.665-5.991-35.14-15.434zm117.122 64.649l28.213 20.113 28.215-20.113L384 411.264l27.848 20.617-34.649.312-11.004 32.856-11.002-32.856-34.648-.312 27.848-20.617z";
            }
        }

        public static string GetFillColor(string descriptor)
        {
            if (string.IsNullOrEmpty(descriptor))
                return "#000000";

            switch (descriptor)
            {
                case "Helpin":
                case "Believin":
                    return "red";
                case "Bossin":
                case "Laborin":
                    return "#000000";
                case "Fiddlin":
                case "Learnin":
                    return "#417505";
                case "Fightin":
                case "Rushin":
                    return "#F5A623";
                case "Slingin":
                case "Occultin":
                    return "lightskyblue";
                case "Shankin":
                case "Cheatin":
                    return "#bd10e0";
                case "Yakkin":
                case "Gamblin":
                    return "#F8E71C";
                case null:
                default:
                    return "#000000";
            }
        }
    }


}
