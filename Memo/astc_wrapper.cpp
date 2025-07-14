#include <cstdint>
#include "astcenc.h"

extern "C" {

    // Placeholder for now
    __declspec(dllexport)
    bool DecodeASTC(const uint8_t* astcData, int dataLength, int width, int height, uint8_t* outRgba, int blockX, int blockY)
    {
        // 1. Validate input sizes (width, height, dataLength)
        // 2. Calculate blocks count from width, height, and block size (usually 4x4)
        // 3. For each block in astcData:
        //      - decompress the block into a temporary RGBA pixel buffer (4x4 pixels)
        //      - copy pixels into the correct position in outRgba
        // 4. Return true if successful

        astcenc_error status;
        astcenc_config config;
        astcenc_context* context;

        // Initialize config for LDR profile, block size matching input dimensions (e.g., 4x4 blocks, or 12x12 here)
        // For now let's assume 4x4 blocks for simplicity:
        status = astcenc_config_init(ASTCENC_PRF_LDR, blockX, blockY, 1, ASTCENC_PRE_MEDIUM, 0, &config);
        if (status != ASTCENC_SUCCESS) return false;

        // Allocate context
        status = astcenc_context_alloc(&config, 1, &context);
        if (status != ASTCENC_SUCCESS) return false;

        // Prepare image struct
        astcenc_image image;
        image.dim_x = width;
        image.dim_y = height;
        image.dim_z = 1;
        image.data_type = ASTCENC_TYPE_U8;

        // The API expects void** for data pointer to pixel slices, so:
        void* data_ptr = reinterpret_cast<void*>(outRgba);
        image.data = &data_ptr;

        // Set swizzle to default (RGBA)
        astcenc_swizzle swizzle = {ASTCENC_SWZ_R, ASTCENC_SWZ_G, ASTCENC_SWZ_B, ASTCENC_SWZ_A};

        // Call decompression
        status = astcenc_decompress_image(context, astcData, dataLength, &image, &swizzle, 0);

        // Free context
        astcenc_context_free(context);

        return (status == ASTCENC_SUCCESS);
    }

}
