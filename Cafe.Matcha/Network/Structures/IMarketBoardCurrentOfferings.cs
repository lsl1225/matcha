﻿// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Network.Structures
{
    using System.Collections.Generic;

    /// <summary>
    /// An interface that represents the current market board offerings.
    /// </summary>
    public interface IMarketBoardCurrentOfferings
    {
        /// <summary>
        /// Gets the list of individual item listings.
        /// </summary>
        IReadOnlyList<IMarketBoardItemListing> ItemListings { get; }

        /// <summary>
        /// Gets the request ID.
        /// </summary>
        int RequestId { get; }
    }

    /// <summary>
    /// An interface that represents the current market board offering of a single item from the <see cref="IMarketBoardCurrentOfferings"/>.
    /// </summary>
    public interface IMarketBoardItemListing
    {
        /// <summary>
        /// Gets the artisan ID.
        /// </summary>
        ulong ArtisanId { get; }

        /// <summary>
        /// Gets the item ID.
        /// </summary>
        uint ItemId { get; }

        /// <summary>
        /// Gets a value indicating whether the item is HQ.
        /// </summary>
        bool IsHq { get; }

        /// <summary>
        /// Gets the item quantity.
        /// </summary>
        uint ItemQuantity { get; }

        /// <summary>
        /// Gets the listing ID.
        /// </summary>
        ulong ListingId { get; }

        /// <summary>
        /// Gets the list of materia attached to this item.
        /// </summary>
        IReadOnlyList<IItemMateria> Materia { get; }

        /// <summary>
        /// Gets the amount of attached materia.
        /// </summary>
        int MateriaCount { get; }

        /// <summary>
        /// Gets a value indicating whether this item is on a mannequin.
        /// </summary>
        bool OnMannequin { get; }

        /// <summary>
        /// Gets the price per unit.
        /// </summary>
        uint PricePerUnit { get; }

        /// <summary>
        /// Gets the city ID of the retainer selling the item.
        /// </summary>
        int RetainerCityId { get; }

        /// <summary>
        /// Gets the ID of the retainer selling the item.
        /// </summary>
        ulong RetainerId { get; }

        /// <summary>
        /// Gets the name of the retainer.
        /// </summary>
        string RetainerName { get; }

        /// <summary>
        /// Gets the first stain or applied dye of the item.
        /// </summary>
        int Stain1Id { get; }

        /// <summary>
        /// Gets the second stain or applied dye of the item.
        /// </summary>
        int Stain2Id { get; }

        /// <summary>
        /// Gets the total tax.
        /// </summary>
        uint TotalTax { get; }
    }

    /// <summary>
    /// An interface that represents the materia slotted to an <see cref="IMarketBoardItemListing"/>.
    /// </summary>
    public interface IItemMateria
    {
        /// <summary>
        /// Gets the materia index.
        /// </summary>
        int Index { get; }

        /// <summary>
        /// Gets the materia ID.
        /// </summary>
        int MateriaId { get; }
    }
}
