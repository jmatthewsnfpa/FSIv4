window.downloadFileFromStream = async (fileName, contentStreamReference) => {
    try {
        const arrayBuffer = await contentStreamReference.arrayBuffer();
        const blob = new Blob([arrayBuffer], {
            type: 'text/csv;charset=utf-8;'
        });

        // Create download link
        const url = URL.createObjectURL(blob);
        const link = document.createElement('a');
        link.href = url;
        link.download = fileName;
        link.style.display = 'none';

        // Add to page and trigger download
        document.body.appendChild(link);
        link.click();

        // Cleanup
        setTimeout(() => {
            document.body.removeChild(link);
            URL.revokeObjectURL(url);
        }, 100);

    } catch (error) {
        console.error('Download error:', error);
        alert('Error downloading file. The file might be too large. Try opening with a text editor instead of Excel.');
    }
};