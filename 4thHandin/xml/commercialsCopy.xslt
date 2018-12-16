<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:c="http://my.company.com"
>
  <xsl:output method="xml" indent="yes"/>


  <xsl:template match="/">
    <commercials>
      <xsl:for-each select="commercials/commercial">
        <commercial>
          <company>
            <xsl:value-of select="company"/>
          </company>
          <webpage>
            <xsl:value-of select="webpage"/>
          </webpage>
          <logo>
            <xsl:value-of select="logo"/>
          </logo>
          <viewcount>
            <xsl:value-of select="viewcount"/>
          </viewcount>
        </commercial>
      </xsl:for-each>
    </commercials>
  </xsl:template>
</xsl:stylesheet>
