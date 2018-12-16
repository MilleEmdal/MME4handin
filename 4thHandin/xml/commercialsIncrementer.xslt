<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:c="http://my.company.com"
>
  <xsl:output method="xml" indent="yes"/>
  <xsl:param name="randomcommercialToDisplayPosition"></xsl:param>

  <xsl:template match="/">
    <commercials>
      <xsl:for-each select="commercials/commercial">
        <commercial>
          <xsl:variable name="id" select="position() - 1" />
          <company>
            <xsl:value-of select="company"/>
          </company>
          <webpage>
            <xsl:value-of select="webpage"/>
          </webpage>
          <logo>
            <xsl:value-of select="logo"/>
            <xsl:value-of select="ourlogo"/>
          </logo>
          <viewcount>
            <xsl:choose>
              <xsl:when test="$id = $randomcommercialToDisplayPosition">
                <xsl:value-of select="viewcount + 1"/>
              </xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="viewcount"/>
              </xsl:otherwise>
            </xsl:choose>
          </viewcount>
        </commercial>
      </xsl:for-each>
    </commercials>
  </xsl:template>
</xsl:stylesheet>
